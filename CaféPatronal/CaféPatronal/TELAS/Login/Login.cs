using CaféPatronal.Programacao;
using CaféPatronal.Programacao.Funcionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaféPatronal.TELAS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você quer mesmo sair?", "Café Patronal",
MessageBoxButtons.YesNo, MessageBoxIcon.Question)
== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioBusiness business = new FuncionarioBusiness();
                FuncionarioDTO funcionario = business.Logar(txtUsuarioLogin.Text, txtSenha.Text);

                if (funcionario != null)
                {
                    UserSession.UsuarioLogado = funcionario;

                    Form1 menu = new Form1();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciais inválidas.", "Michael Pop`s", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message);

            }
        }
    }
}
