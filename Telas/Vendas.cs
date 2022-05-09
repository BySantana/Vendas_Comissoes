using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoTecnica2.Telas
{
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }
        public static double valorTotal = 0;
        List<Classes.Produto> produtos = Classes.Produto.Produtos;
        public static List<Classes.Produto> produtosComprados = new List<Classes.Produto>();

        private void Vendas_Load(object sender, EventArgs e)
        {
            lsbProdutos.Items.AddRange(produtos.ToArray());
            valorTotal = 0;
            cbFuncionarios.Items.AddRange(Classes.Funcionario.MostrarFuncionarios().ToArray());
        }

        private void lsbProdutos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = 0;
            foreach (var item in lsbProdutos.Items)
            {
                if (lsbProdutos.SelectedIndex == i)
                {
                    Classes.Venda venda = new Classes.Venda();
                    valorTotal += venda.CalcularValorTotal(i);
                    lblValorTotal.Text = "R$"+valorTotal;
                    cbCarrinhoCompras.Items.Add(lsbProdutos.Items[i]);
                    produtosComprados.Add(produtos[i]);
                }
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(valorTotal > 0)
            {
                groupBox1.Enabled = true;
                cbFormaPagamento.Items.Clear();
                cbFormaPagamento.Items.Add("Cartão de crédito");
                cbFormaPagamento.Items.Add("PIX");
                cbFormaPagamento.Items.Add("Boleto");
                for (int i = 1; i < 8; i++)
                {
                    cbNumeroParcelas.Items.Add("" + i);
                }
            }
        }

        private void cbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int escolha = cbFormaPagamento.SelectedIndex;
            switch (escolha)
            {
                case 0:            
                    cbNumeroParcelas.Enabled = true;
                    cbNumeroParcelas.Visible = true;
                    break;
                case 1:
                    int chave = new Random().Next(10000, 99000);
                    label2.Text = "CHAVE PIX: ";
                    lblParcela.Text = chave.ToString();
                    label2.Visible = true;
                    lblParcela.Visible = true;
                    cbNumeroParcelas.Enabled = false;
                    break;
                case 2:
                    label2.Visible = false;
                    lblParcela.Visible = false;
                    cbNumeroParcelas.Enabled = false;
                    break;
            }
        }

        private void cbNumeroParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < cbNumeroParcelas.Items.Count; i++)
            {
                if (cbNumeroParcelas.SelectedIndex == i)
                {
                    label2.Text = "VALOR DAS PARCELAS:";
                    lblParcela.Text = $"R${(valorTotal / (i+1)):f2}";
                    label2.Visible = true;
                    lblParcela.Visible = true;
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string i = cbCarrinhoCompras.Text;           
            cbCarrinhoCompras.Items.RemoveAt(cbCarrinhoCompras.SelectedIndex);
            Classes.Produto resp = produtosComprados.Find(p => p.ToString() == i);
            if (resp != null)
            {
                produtosComprados.Remove(resp);
            }
            double valor = double.Parse(i.Substring(i.IndexOf('$')+1));
            valorTotal -= valor;
            lblValorTotal.Text = "R$"+valorTotal;
            cbCarrinhoCompras.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Classes.Venda.GerarComissao(cbFuncionarios.Text, valorTotal);
            NotaFiscal nota = new NotaFiscal();
            nota.Show();   
        }
    }
}
