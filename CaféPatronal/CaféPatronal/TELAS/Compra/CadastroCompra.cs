using CaféPatronal.Programacao;
using CaféPatronal.Programacao.Entregável_2.Compras;
using CaféPatronal.Programacao.Entregável_2.Compras.ProdutoCompra;
using CaféPatronal.Programacao.Estoque;
using CaféPatronal.Programacao.Produto;
using CaféPatronal.TELAS.Cadastro_e_Consulta;
using Loja_de_roupas.DB.Estoque;
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
        BindingList<Programacao.Entregável_2.Compras.ProdutoCompra.ProdutoCompraDTO> produtosCarrinho = new BindingList<Programacao.Entregável_2.Compras.ProdutoCompra.ProdutoCompraDTO>();
        decimal valortotal = 0;
        Validação v = new Validação();
        public CadastroCompra()
        {
            InitializeComponent();
            CarregarCombos();
        }
        public void CarregarCombos()
        {
            FOrnecedorBusiness bus = new FOrnecedorBusiness();
            List<FornecedorDTO> lista = bus.Listar();
            cbfornecedor.ValueMember = nameof(FornecedorDTO.id_fornecedor);
            cbfornecedor.DisplayMember = nameof(FornecedorDTO.nm_nome);
            cbfornecedor.DataSource = lista;

            ProdutoCompraBusiness busi = new ProdutoCompraBusiness();
            List<Programacao.Entregável_2.Compras.ProdutoCompra.ProdutoCompraDTO> list = busi.Consultar(string.Empty);
            cmbCompra.DisplayMember = nameof(ProdutoCompraDTO.nm_produtocompra);
            cmbCompra.ValueMember = nameof(ProdutoCompraDTO.id_produtocompra);
            cmbCompra.DataSource = list;

        }
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
            ProdutoCompraDTO dto = new ProdutoCompraDTO();
            dto.nm_produtocompra = txtProdutoComprado.Text;
            dto.vl_valor = decimal.Parse(txtValor.Text);
            ProdutoCompraBusiness business = new ProdutoCompraBusiness();
            int idproduto = business.Salvar(dto);

            EstoqueDTO estoquedto = new EstoqueDTO();
            estoquedto.id_produtocompra = idproduto;
            estoquedto.ds_quantidade = 0;
            EstoqueBusiness estoque = new EstoqueBusiness();
            estoque.Salvar(estoquedto);
            MessageBox.Show("Produto de compra cadastrado com sucesso");


        }


        private void btnConsultarFornece_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoCompraBusiness business = new ProdutoCompraBusiness();
                List<ProdutoCompraDTO> a = business.Consultar(txtConsultaCompra.Text);
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = a;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                FornecedorDTO fornecedor = cbfornecedor.SelectedItem as FornecedorDTO;
                ComprasDTO compra = new ComprasDTO();
                compra.dt_compra = DateTime.Now;
                compra.id_fornecedor = fornecedor.id_fornecedor;




                ComprasBusiness business = new ComprasBusiness();
                int idcompra = business.Salvar(compra, produtosCarrinho.ToList());

                MessageBox.Show("Compra realizada com sucesso");

                produtosCarrinho = new BindingList<ProdutoCompraDTO>();
                valortotal = 0;
                lblvalortotal.Text = "R$ " + valortotal.ToString();
                dataGridView1.DataSource = produtosCarrinho;
                txtQuantidade.Clear();
                EstoqueBusiness businessestoque = new EstoqueBusiness();
                CompraItemBusiness compraItemBusiness = new CompraItemBusiness();
                List<VwConsultarItem> lista = compraItemBusiness.ConsultarViewPorId(idcompra);
                List<EstoqueDTO> estoque = businessestoque.Listar();


                foreach (VwConsultarItem item in lista)
                {
                    foreach (EstoqueDTO item2 in estoque)
                    {
                        if (item.id_produtocompra == item2.id_produtocompra)
                        {
                            item2.ds_quantidade = item2.ds_quantidade + item.qtd_itens;
                        }
                    }
                }


                foreach (EstoqueDTO item in estoque)
                {
                    EstoqueDTO estoquedto = new EstoqueDTO();

                    estoquedto.id_produtocompra = item.id_produtocompra;
                    estoquedto.ds_quantidade = item.ds_quantidade;

                    businessestoque.Alterar(estoquedto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ocorreu o erro: " + ex.Message);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                CompraItemBusiness business = new CompraItemBusiness();
                List<VwConsultarItem> a = business.ConsultarView(txtConsultaCompra.Text);
                dgvConsultarCompra.AutoGenerateColumns = false;
                dgvConsultarCompra.DataSource = a;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }

        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.numeros(e);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.letras(e);
        }

        private void txtqtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.numeros(e);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
             Form1 tela = new Form1();
            tela.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                int quantidade = 0;
                ProdutoCompraDTO dto = cmbCompra.SelectedItem as ProdutoCompraDTO;
                int qtd = Convert.ToInt32(txtQuantidade.Text);

                for (int i = 0; i < qtd; i++)
                {
                    produtosCarrinho.Add(dto);
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = produtosCarrinho;
                    valortotal = valortotal + dto.vl_valor;
                    quantidade = quantidade + 1;

                }
                lblvalortotal.Text = "R$ " + valortotal.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu o erro : " + ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.numeros(e);
        }
    }
}

