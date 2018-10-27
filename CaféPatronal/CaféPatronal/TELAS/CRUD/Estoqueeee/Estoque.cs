using CaféPatronal.Programacao;
using CaféPatronal.Programacao.Produto;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CaféPatronal.TELAS
{
    public partial class Consulta_de_Estoque : Form
    {
        Validação V = new Validação();
        public Consulta_de_Estoque()
        {
            InitializeComponent();
            CarregarCombos();
        }
        void CarregarCombos()
        {
            ProdutoBusiness  bus = new ProdutoBusiness();
            List<ProdutoDTO> lista = bus.Listar();
            cbProduto.DisplayMember = nameof(ProdutoDTO.nm_nome);
            cbProduto.DataSource = lista;
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
       
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnConsultarestoque_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtConsultarEstoque.Text == string.Empty)
            //    {
            //        EstoqueBusiness businessw = new EstoqueBusiness();
            //        List<vwEstoque> vww = businessw.Listar();

            //        dgvconsultaestoq.AutoGenerateColumns = false;
            //        dgvconsultaestoq.DataSource = vww;
            //    }
            //    else
            //    {
            //        EstoqueBusiness business = new EstoqueBusiness();
            //        List<vwEstoque> vw = business.Consultar(txtConsultarEstoque.Text);

            //        dgvconsultaestoq.AutoGenerateColumns = false;
            //        dgvconsultaestoq.DataSource = vw;
            //    }
            //}

            //catch(Exception ex)
            //{
            //    MessageBox.Show("Ocorreu um erro: " + ex.Message);
            //}
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();
        }
    }
}
