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
    public partial class ComissaoFuncionario : Form
    {
        public ComissaoFuncionario()
        {
            InitializeComponent();
        }
        private void ComissaoFuncionario_Load(object sender, EventArgs e)
        {
            double comissao = Classes.Funcionario.MostrarComissao(btnLogin.email);
            lblComissao.Text = $"R${comissao:F2}";
        }
    }
}
