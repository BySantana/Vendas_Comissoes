using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AvaliacaoTecnica2.Classes
{
    [System.Serializable]
    internal class Cliente
    {
        string Nome { get; set; }
        string Email { get; set; }
        string Telefone { get; set; }
        string Senha { get; set; }
        public static List<Cliente> Clientes = new List<Cliente>();

        public Cliente(string nome, string email, string telefone, string senha)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Senha = senha;
        }
        public override string ToString()
        {
            return $"{Nome} => {Email}, {Senha}";
        }
        public void CadastrarCliente()
        {
            Clientes.Add(new Cliente(Nome, Email, Telefone, Senha));
            SalvarArquivo();
        }
        public static void SalvarArquivo()
        {
            FileStream stream = new FileStream("Clientes.txt", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, Clientes);
            stream.Close();
        }

        public static bool VerificaLogin(string email, string senha)
        {
            Cliente resuEmail = Clientes.Find(c => c.Email == email);
            if(resuEmail != null)
            {
                if(resuEmail.Senha == senha)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool ExcluirCliente(string email, string senha) 
        {
            Cliente resuEmail = Clientes.Find(c => c.Email == email);
            if (resuEmail != null)
            {
                if (resuEmail.Senha == senha)
                {
                    Clientes.Remove(resuEmail);
                    SalvarArquivo();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool AtualizarCliente(string nome, string telefone, string email, string senha)
        {
            
            foreach(Cliente cliente in Clientes)
            {
                if (cliente.Email == email)
                {
                    cliente.Telefone = telefone;
                    cliente.Senha = senha;
                    cliente.Nome = nome;
                    SalvarArquivo();
                    return true;   
                }
            }
            return false;
        }

        
    }
}
