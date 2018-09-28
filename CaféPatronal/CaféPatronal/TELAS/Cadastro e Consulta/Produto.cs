using CaféPatronal.Programacao;
using CaféPatronal.Programacao.Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaféPatronal.TELAS.Cadastro_e_Consulta
{
    public partial class CadastrarProduto : Form
    {
        Validação V = new Validação();
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.letras(e);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();
        }

        private void BtnSalvarProdutos_Click(object sender, EventArgs e)
        {
            try
            {

                ProdutoDTO dto = new ProdutoDTO();
                dto.nm_nome = TxtNomeProduto.Text;
                dto.ds_unidade = cboUnidade.Text;
                dto.dt_validade = dtpDataValidade.Value;

                ProdutoBusiness business = new ProdutoBusiness();
                business.Salvar(dto);

                MessageBox.Show("Produto salvo com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um  erro: " + ex.Message);
            }
        }

        private void btnConsultarFornece_Click(object sender, EventArgs e)
        {
            ProdutoBusiness Business = new ProdutoBusiness();
            List<ProdutoDTO> a = Business.Consultar(txtConsultaProdutos.Text);
            dgvconsultaproduto.AutoGenerateColumns = false;
            dgvconsultaproduto.DataSource = a;
        }
    }
}
