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
    public partial class RemoverFuncionario : Form
    {
        public RemoverFuncionario()
        {
            InitializeComponent();
        }


        private void btnSim_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bool resu = Classes.Funcionario.ExcluirFuncionario(txtLogin.Text, txtSenha.Text);
            if(resu == true)
            {
                MessageBox.Show("FUNCIONÁRIO EXCLUÍDO COM SUCESSO!", "ATENÇÃO!");
            }
            else
            {
                MessageBox.Show("DADOS INCORRETOS!", "ATENÇÃO!");
            }
        }
    }
}
