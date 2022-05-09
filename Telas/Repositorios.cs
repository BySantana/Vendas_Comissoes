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
    public partial class Repositorios : Form
    {
        public Repositorios()
        {
            InitializeComponent();
        }

        private void Repositorios_Load(object sender, EventArgs e)
        {
            lsbFuncionarios.Items.AddRange(Classes.Funcionario.Funcionarios.ToArray());
            lsbClientes.Items.AddRange(Classes.Cliente.Clientes.ToArray());
            lsbProdutos.Items.AddRange(Classes.Produto.Produtos.ToArray());
        }
    }
}
