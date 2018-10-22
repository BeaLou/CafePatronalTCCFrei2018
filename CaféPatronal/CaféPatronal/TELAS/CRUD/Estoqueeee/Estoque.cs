using CaféPatronal.Programacao;
using CaféPatronal.TELAS.CRUD.Estoqueeee;
using Loja_de_roupas.DB.Estoque;
using mecanica.DB.Programação.Estoque;
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
    public partial class Consulta_de_Estoque : Form
    {
        Validação V = new Validação();
        public Consulta_de_Estoque()
        {
            InitializeComponent();
        }

        private void Consulta_de_Estoque_Load(object sender, EventArgs e)
        {

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.numeros(e);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlterarEstoque tela = new AlterarEstoque();
            tela.Show();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnConsultarestoque_Click(object sender, EventArgs e)
        {
            EstoqueBusiness business = new EstoqueBusiness();
            List<vwEstoque> vw = business.Consultar(txtConsultarEstoque.Text);

            dgvconsultaestoq.AutoGenerateColumns = false;
            dgvconsultaestoq.DataSource = vw;

        }
    }
}
