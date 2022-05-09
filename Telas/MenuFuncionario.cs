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
    public partial class MenuFuncionario : Form
    {
        public MenuFuncionario()
        {
            InitializeComponent();
        }

        private void btnComissao_Click(object sender, EventArgs e)
        {
            ComissaoFuncionario comissaoFuncionario = new ComissaoFuncionario();
            comissaoFuncionario.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            produtos.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            RemoverFuncionario funcionario = new RemoverFuncionario();
            funcionario.ShowDialog();
        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            AtualizaFuncionario atualizaFuncionario = new AtualizaFuncionario();
            atualizaFuncionario.ShowDialog();
        }
    }
}
