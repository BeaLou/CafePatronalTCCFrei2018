using CaféPatronal.Programacao;
using CaféPatronal.Programacao.Produto;
using CaféPatronal.TELAS.CRUD.Produ;
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
                dto.vl_unidade = txtUnidade.Text;
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvconsultaproduto.CurrentRow != null)
                {
                    ProdutoDTO fornecedor = dgvconsultaproduto.CurrentRow.DataBoundItem as ProdutoDTO;

                    AlterarProduto tela = new AlterarProduto();
                    tela.LoadScreen(fornecedor);
                    tela.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Selecione um Produto");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvconsultaproduto.CurrentRow != null)
                {
                    ProdutoDTO produto = dgvconsultaproduto.CurrentRow.DataBoundItem as ProdutoDTO;
                    DialogResult r = MessageBox.Show("Deseja excluir esse Produto?", "Michael Pop`s",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        ProdutoBusiness business = new ProdutoBusiness();
                        business.Remover(produto.id_produto);

                        List<ProdutoDTO> a = business.Consultar(txtConsultaProdutos.Text);
                        dgvconsultaproduto.AutoGenerateColumns = false;
                        dgvconsultaproduto.DataSource = a;

                    }
                    else
                    {
                        MessageBox.Show("Selecione um cliente");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }
    }
}
