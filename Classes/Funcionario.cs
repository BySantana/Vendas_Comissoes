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
    public class Funcionario
    {
        public string Nome { get; set; }
        string Email { get; set; }
        string Telefone { get; set; }
        string Senha { get; set; }
        public double ComissaoTotal { get; set; }
        public static List<Funcionario> Funcionarios = new List<Funcionario>();

        public Funcionario(string nome, string email, string telefone, string senha, double comissaoTotal)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Senha = senha;
            ComissaoTotal = comissaoTotal;
        }

        public override string ToString()
        {
            return $"{Nome} => {Email}, {Senha} => R${ComissaoTotal}";
        }

        public static void SalvarArquivo()
        {
            FileStream stream = new FileStream("Funcionarios.txt", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, Funcionarios);
            stream.Close();
        }

        public void CadastrarFuncionario()
        {
            Funcionarios.Add(new Funcionario(Nome, Email, Telefone, Senha, 0));
            SalvarArquivo();
        }

        public static bool VerificaLogin(string login, string senha)
        {
            Funcionario resuFuncionario = Funcionarios.Find(f => f.Email == login);
            
            if(resuFuncionario != null)
            {
                if(resuFuncionario.Senha == senha)
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

        public static double MostrarComissao(string email)
        {
            foreach(Funcionario funcionario in Funcionarios)
            {
                if(funcionario.Email == email)
                {
                    return funcionario.ComissaoTotal;
                }
            }
            return 0;
        }

        public static List<string> MostrarFuncionarios()
        {
            List<string> mostra = new List<string>();
            foreach(Funcionario funcionario in Funcionarios)
            {
                mostra.Add(funcionario.Nome);
            }
            return mostra;
        }

        public static bool ExcluirFuncionario(string email, string senha)
        {
            foreach (Funcionario funcionario in Funcionarios)
            {
                if (funcionario.Email == email && funcionario.Senha == senha)
                {
                    Funcionarios.Remove(funcionario);
                    SalvarArquivo();
                    return true;
                }
            }
            return false;
        }

        public static bool AtualizarFuncionario(string nome, string telefone, string email, string senha)
        {
            foreach (Funcionario funcionario in Funcionarios)
            {
                if (funcionario.Email == email)
                {   
                    funcionario.Telefone = telefone;
                    funcionario.Senha = senha;
                    funcionario.Nome = nome;
                    SalvarArquivo();
                    return true;
                }
            }
            return false;
        }
        
    }
}
