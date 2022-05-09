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
    public partial class AtualizaFuncionario : Form
    {
        public AtualizaFuncionario()
        {
            InitializeComponent();
        }

        private void AtualizaFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            bool resu = Classes.Funcionario.AtualizarFuncionario(txtNome.Text, txtTelefone.Text, btnLogin.email, txtSenha.Text);
            if(resu == true)
            {
                MessageBox.Show("FUNCIONÁRIO ALTERADO COM SUCESSO", "ATENÇÃO");
            }
            else
            {
                MessageBox.Show("FUNCIONÁRIO NÃO ENCONTRADO!", "ATENÇÃO");
            }
        }
    }
}
