using CaféPatronal.Programacao;
using CaféPatronal.Programacao.Entregável_2.Compras;
using CaféPatronal.Programacao.Estoque;
using CaféPatronal.Programacao.Produto;
using CaféPatronal.TELAS.Cadastro_e_Consulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaféPatronal.TELAS.Compra
{
    public partial class CadastroCompra : Form
    {
        BindingList<ComprasDTO> produtosCarrinho = new BindingList<ComprasDTO>();
        Validação v = new Validação();
        public CadastroCompra()
        {
            InitializeComponent();
            CarregarCombos();
        }
        void CarregarCombos()
        {
            FOrnecedorBusiness bus = new FOrnecedorBusiness();
            List<FornecedorDTO> lista = bus.Listar();
            cbfornecedor.DisplayMember = nameof(FornecedorDTO.nm_nome);
            cbfornecedor.DataSource = lista;

            ProdutoBusiness business = new ProdutoBusiness();
            List<ProdutoDTO> listaa = business.Listar();
            cmbProduto.ValueMember = nameof(ProdutoDTO.id_produto);
            cmbProduto.DisplayMember = nameof(ProdutoDTO.nm_nome);
            cmbProduto.DataSource = listaa;

            ComprasBusiness busi = new ComprasBusiness();
            List<ComprasDTO> list = busi.Listar();
            cmbCompra.ValueMember = nameof(ComprasDTO.id_compra);
            cmbCompra.DisplayMember = nameof(ComprasDTO.nm_compra);
            cmbCompra.DataSource = list;

        }
        CompraItemDTO compraaaaaitemmmm = new CompraItemDTO();

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();
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
                FornecedorDTO fornecedor = cbfornecedor.SelectedItem as FornecedorDTO;
                ComprasDTO dto = new ComprasDTO();
                dto.id_fornecedor = fornecedor.id_fornecedor;
                dto.nm_compra = txtNome.Text;
                dto.qtd_unidade = cmbunidade.Text;
                dto.vl_compra = Convert.ToDecimal(txtVlcompra.Text);
                dto.dt_compra = DateTime.Now;

                ComprasBusiness bussiness = new ComprasBusiness();
                bussiness.Salvar(dto);
                MessageBox.Show("Compra realizada com sucesso.");
                txtNome.Clear();
                txtVlcompra.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex.Message);
            }



        }
   

        private void btnConsultarFornece_Click(object sender, EventArgs e)
        {
            ComprasBusiness business = new ComprasBusiness();
            List<ComprasDTO> a = business.Consultar(txtConsultaCompra.Text);
            dgvconsultacompra.AutoGenerateColumns = false;
            dgvconsultacompra.DataSource = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvconsultacompra.CurrentRow != null)
                {
                    ComprasDTO compra = dgvconsultacompra.CurrentRow.DataBoundItem as ComprasDTO;
                    DialogResult r = MessageBox.Show("Deseja excluir essa compra?", "Café Patronal",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);

                  
                        if (r == DialogResult.Yes)
                        {
                            ComprasBusiness business = new ComprasBusiness();
                            business.Remover(compra.id_compra);

                            List<ComprasDTO> a = business.Consultar(txtConsultaCompra.Text);
                            dgvconsultacompra.AutoGenerateColumns = false;
                            dgvconsultacompra.DataSource = a;

                        }
                    

                }
                else
                {
                    MessageBox.Show("Selecione uma Compra");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();

        }

        private void txtVlcompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.numeros(e);
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ComprasDTO compra = cmbCompra.SelectedItem as ComprasDTO;
                ProdutoDTO dto = cmbProduto.SelectedItem as ProdutoDTO;

                int qtd = Convert.ToInt32(txtQuantidade.Text);

                for (int i = 0; i < qtd; i++)
                {
                    produtosCarrinho.Add(compra);
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = produtosCarrinho;
                    compraaaaaitemmmm.id_produto = dto.id_produto;
                }



            }

            catch (Exception ex)
            {
                MessageBox.Show("ocorreu o erro" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            produtosCarrinho = new BindingList<ComprasDTO>();
            dataGridView1.DataSource = produtosCarrinho;
            compraaaaaitemmmm = new CompraItemDTO();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                ProdutoDTO produto = cmbProduto.SelectedItem as ProdutoDTO;


                ComprasBusiness business = new ComprasBusiness();
                business.SalvarItem(compraaaaaitemmmm, produtosCarrinho.ToList());

                MessageBox.Show("Items adicionados com sucesso.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ocorreu o erro: " + ex.Message);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarCombos();
        }
    }
}

