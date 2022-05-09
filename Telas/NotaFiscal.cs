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
    public partial class NotaFiscal : Form
    {
        public NotaFiscal()
        {
            InitializeComponent();
        }

        private void NotaFiscal_Load(object sender, EventArgs e)
        {
            lsbNotaFiscal.Items.AddRange(Vendas.produtosComprados.ToArray());
            lblValorFinal.Text = Vendas.valorTotal.ToString();
            Vendas.produtosComprados.Clear();
        }
    }
}
