using CaféPatronal.Programacao;
using CaféPatronal.Programacao.Entregável_2.Compras.ProdutoCompra;
using CaféPatronal.Programacao.Entregável_4.Estoque;
using CaféPatronal.Programacao.Produto;
using Loja_de_roupas.DB.Estoque;
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
            ProdutoCompraBusiness busi = new ProdutoCompraBusiness();
            List<Programacao.Entregável_2.Compras.ProdutoCompra.ProdutoCompraDTO> list = busi.Consultar(string.Empty);
            cbProduto.DisplayMember = nameof(ProdutoCompraDTO.nm_produtocompra);
            cbProduto.ValueMember = nameof(ProdutoCompraDTO.id_produtocompra);
            cbProduto.DataSource = list;

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
            try
            {
                EstoqueBusiness business = new EstoqueBusiness();
                List<vwconsultarestoque> a = business.ConsultarEstoque(txtConsultarEstoque.Text);
                dgvué.AutoGenerateColumns = false;
                dgvué.DataSource = a;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();
        }

        private void BtnSalvarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblAtual.Text == "0")
                {
                    MessageBox.Show("Pesquise o Produto de compra");
                }
                if (nudQtd.Value == 0)
                {
                    MessageBox.Show("Coloque o valor para retirar");
                }

                else
                {
                    ProdutoCompraDTO dto = cbProduto.SelectedItem as ProdutoCompraDTO;
                    EstoqueDTO estoque = new EstoqueDTO();
                    EstoqueBusiness business = new EstoqueBusiness();
                    estoque.id_produtocompra = dto.id_produtocompra;
                    estoque.ds_quantidade = Convert.ToDecimal(lblAtual.Text) - nudQtd.Value;
                    business.Alterar(estoque);
                    MessageBox.Show("Estoque alterado com sucesso");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void Pesquisar_Click(object sender, EventArgs e)
        {
            ProdutoCompraDTO dto = cbProduto.SelectedItem as ProdutoCompraDTO;
            EstoqueBusiness business = new EstoqueBusiness();
            vwconsultarestoque view = business.ConsultarEstoqueView(dto.nm_produtocompra);
            lblAtual.Text = view.ds_quantidade.ToString();
        }

        private void cbProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.letras(e);
        }

        private void nudQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.numeros(e);
        }
    }
}
