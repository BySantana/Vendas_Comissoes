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
    public class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public static List<Produto> Produtos = new List<Produto>();

        public Produto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public override string ToString()
        {
            return $"{Nome} --> R${Valor}";
        }
        public static void SalvarArquivo()
        {
            FileStream stream = new FileStream("Produtos.txt", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            encoder.Serialize(stream, Produtos);
            stream.Close();
        }

        public void CadastrarProduto()
        {
            Produtos.Add(new Produto(Nome, Valor));
            SalvarArquivo();
        }

        public static bool RemoverProduto(string nome)
        {
            foreach (Produto produto in Produtos)
            {
                if (produto.Nome == nome)
                {
                    Produtos.Remove(produto);
                    return true;
                }
            }
            return false;
        }


    }
}
