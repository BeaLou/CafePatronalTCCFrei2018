using CaféPatronal.Programacao;
using CaféPatronal.Programacao.Entregável_2.Compras;
using CaféPatronal.Programacao.Estoque;
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
        public CadastroCompra()
        {
            InitializeComponent();
            CarregarCombos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            CadastrarProduto tela = new CadastrarProduto();
            tela.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CadastrarProduto tela = new CadastrarProduto();
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
                dto.qtd_unidade = txtUnidade.Text;
                dto.vl_compra = Convert.ToDecimal(txtVlcompra.Text);
                dto.dt_compra = dtpDatacompra.Value;

                ComprasBusiness bussiness = new ComprasBusiness();
                bussiness.Salvar(dto);
                MessageBox.Show("Compra realizada com sucesso.");
                txtNome.Clear();
                txtUnidade.Clear();
                txtVlcompra.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex.Message);
            }



        }
        void CarregarCombos()
        {
            FOrnecedorBusiness bus = new FOrnecedorBusiness();
            List<FornecedorDTO> lista = bus.Listar();
            cbfornecedor.DisplayMember = nameof(FornecedorDTO.nm_nome);
            cbfornecedor.DataSource = lista;
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
    }
}

