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
    internal class Deserialize
    {
        public static void CarregarClientes()
        {
            FileStream stream = new FileStream("Clientes.txt", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            try
            {
                Cliente.Clientes = (List<Cliente>)encoder.Deserialize(stream);

                if (Cliente.Clientes == null)
                {
                    Cliente.Clientes = new List<Cliente>();
                }
            }
            catch (Exception ex)
            {
                Cliente.Clientes = new List<Cliente>();
            }

            stream.Close();

        }

        public static void CarregarProdutos()
        {
            FileStream stream = new FileStream("Produtos.txt", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            try
            {
                Produto.Produtos = (List<Produto>)encoder.Deserialize(stream);

                if (Produto.Produtos == null)
                {
                    Produto.Produtos = new List<Produto>();
                }
            }
            catch (Exception ex)
            {
                Produto.Produtos = new List<Produto>();
            }

            stream.Close();
        }

        public static void CarregarFuncionarios()
        {
            FileStream stream = new FileStream("Funcionarios.txt", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            try
            {
                Funcionario.Funcionarios = (List<Funcionario>)encoder.Deserialize(stream);

                if (Funcionario.Funcionarios == null)
                {
                    Funcionario.Funcionarios = new List<Funcionario>();
                }
            }
            catch(Exception ex)
            {
                Funcionario.Funcionarios = new List<Funcionario>();
            }

            stream.Close();
            
        }
    }
}
