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
    public partial class AtualizaCliente : Form
    {
        public AtualizaCliente()
        {
            InitializeComponent();
        }
        string email = btnLogin.email;
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            bool resuUpdate = Classes.Cliente.AtualizarCliente(txtNome.Text, txtTelefone.Text, email, txtSenha.Text);
            if(resuUpdate == true)
            {
                MessageBox.Show("CLIENTE ALTERADO COM SUCESSO!", "ATENÇÃO");
            }
            else
            {
                MessageBox.Show("CLIENTE NÃO ENCONTRADO", "ATENÇÃO");
            }
        }

        private void AtualizaCliente_Load(object sender, EventArgs e)
        {
            txtEmail.Text = btnLogin.email;
        }
    }
}
