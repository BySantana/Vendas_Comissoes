using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoTecnica2.Classes
{
    public class Venda
    {

        public double CalcularValorTotal(int cont)
        {
            double valorTotal = 0;
            valorTotal += Produto.Produtos[cont].Valor;
            return valorTotal;
        }
        public static List<Produto> EmitirNotaFiscal(List<Produto> produtos)
        {
            List<Produto> fiscal = new List<Produto>();
            foreach (Produto produto in produtos)
            {
                fiscal.Add(produto);
            }
            return fiscal;
        }

        public static void GerarComissao(string nome, double valor)
        {
            foreach (Funcionario funcionario in Funcionario.Funcionarios)
            {
                if (funcionario.Nome == nome)
                {
                    funcionario.ComissaoTotal += valor * 0.05;
                    Funcionario.SalvarArquivo();
                }

            }
        }

    }
}
