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
    public partial class btnCadastro : Form
    {
        public btnCadastro()
        {
            InitializeComponent();
        }

        private void rdbCliente_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void rdbFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbCliente.Checked)
            {
                Classes.Cliente cliente = new Classes.Cliente(txtNome.Text, txtEmail.Text, txtTelefone.Text, txtSenha.Text);
                cliente.CadastrarCliente();
                MessageBox.Show("CLIENTE CADASTRADO COM SUCESSO", "ATENÇÃO");
            }else if (rdbFuncionario.Checked)
            {
                Classes.Funcionario funcionario = new Classes.Funcionario(txtNome.Text, txtEmail.Text, txtTelefone.Text, txtSenha.Text, 0);
                funcionario.CadastrarFuncionario();
                MessageBox.Show("FUNCIONARIO CADASTRADO COM SUCESSO", "ATENÇÃO");
            }
            
        }
    }
}
