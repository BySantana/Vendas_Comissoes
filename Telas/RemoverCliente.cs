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
    public partial class RemoverCliente : Form
    {
        public RemoverCliente()
        {
            InitializeComponent();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == btnLogin.email)
            {
                bool resp = Classes.Cliente.ExcluirCliente(txtLogin.Text, txtSenha.Text);
                if (resp == true)
                {
                    MessageBox.Show("CLIENTE EXCLUÍDO COM SUCESSO!", "ATENÇÃO");
                }
                else
                {
                    MessageBox.Show("CLIENTE NÃO ENCONTRADO!", "ATENÇÃO");
                }
            }
            else
            {
                MessageBox.Show("DADOS INCORRETOS!", "ATENÇÃO");
            }
            
        }
    }
}
