using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoTecnica2
{
    public partial class btnLogin : Form
    {
        public btnLogin()
        {
            InitializeComponent();
        }
        public static string email = "";

        private void rdbCliente_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbCliente.Checked == true)
            {
                groupBox2.Enabled = true;
            }
        }

        private void rdbFuncionario_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbFuncionario.Checked == true)
            {
                groupBox2.Enabled = true;
            }
        }

        private void btnAcessar_Click_1(object sender, EventArgs e)
        {
            if (rdbCliente.Checked == true)
            {
                bool resuCliente = Classes.Cliente.VerificaLogin(txtLogin.Text, txtSenha.Text);
                if (resuCliente == true)
                {
                    email = txtLogin.Text;
                    Telas.MenuCliente menuCliente = new Telas.MenuCliente();
                    menuCliente.ShowDialog();
                }
                else
                {
                    MessageBox.Show("LOGIN INCORRETO", "ATENÇÃO");
                }
            }
            else if (rdbFuncionario.Checked == true)
            {
                bool resuFuncionario = Classes.Funcionario.VerificaLogin(txtLogin.Text, txtSenha.Text);
                if(resuFuncionario == true)
                {
                    email = txtLogin.Text;
                    Telas.MenuFuncionario menuFuncionario = new Telas.MenuFuncionario();
                    menuFuncionario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("LOGIN INCORRETO", "ATENÇÃO");
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Telas.btnCadastro cadastro = new Telas.btnCadastro();
            cadastro.ShowDialog();
        }

        private void btnLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void repositórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Repositorios repositorios = new Telas.Repositorios();
            repositorios.ShowDialog();
        }
    }
}
