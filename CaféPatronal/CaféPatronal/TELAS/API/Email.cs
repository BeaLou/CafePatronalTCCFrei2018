using Nsf._2018.Modulo2.DB.Filosofia.Plugin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaféPatronal.TELAS.API
{
    public partial class Enviar_Email : Form
    {
        public Enviar_Email()
        {
            InitializeComponent();
        }
        Email email = new Email();
        private void Enviar_Email_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                email.Mensagem = txtMensagem.Text.Trim();
                email.Assunto = txtAssunto.Text.Trim();
                email.Para = txtPara.Text.Trim();

                email.Enviar();

                MessageBox.Show("Mensagem enviada com sucesso", "Cafe Patronal");
                txtMensagem.Clear();
                txtAssunto.Clear();
                txtPara.Clear();
                button1.Text="Anexar";
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ocorreu o erro : " + Ex.Message);
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();
        }
        private void txtAnexo_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog janela = new OpenFileDialog();
            janela.ShowDialog();

            button1.Text = janela.FileName;

            email.AdicionarAnexo(janela.FileName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog janela = new OpenFileDialog();
            janela.ShowDialog();

            button1.Text = janela.FileName;

            email.AdicionarAnexo(janela.FileName);
        }
    }
}
