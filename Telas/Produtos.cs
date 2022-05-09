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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            lstProdutos.Items.AddRange(Classes.Produto.Produtos.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstProdutos.Items.Clear();
            Classes.Produto newProduto = new Classes.Produto(txtNome.Text, double.Parse(txtValor.Text));
            newProduto.CadastrarProduto();
            lstProdutos.Items.AddRange(Classes.Produto.Produtos.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool resuRemover = Classes.Produto.RemoverProduto(txtProduto.Text);
            if(resuRemover == true)
            {
                lstProdutos.Items.Clear();
                MessageBox.Show("PRODUTO EXCLUÍDO COM SUCESSO", "ATENÇÃO");
                lstProdutos.Items.AddRange(Classes.Produto.Produtos.ToArray());
            }
            else
            {
                MessageBox.Show("PRODUTO NÃO EXISTE", "ATENÇÃO");
            }
        }

        
    }
}
