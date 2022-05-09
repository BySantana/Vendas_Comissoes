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
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Vendas venda = new Vendas();
            venda.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoverCliente removerCliente = new RemoverCliente();
            removerCliente.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AtualizaCliente atualiza = new AtualizaCliente();
            atualiza.ShowDialog();
        }
    }
}
