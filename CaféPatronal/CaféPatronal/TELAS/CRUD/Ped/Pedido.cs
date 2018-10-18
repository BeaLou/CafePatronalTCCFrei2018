using CaféPatronal.Programacao;
using CaféPatronal.Programacao.Cliente;
using CaféPatronal.Programacao.Entregável_3.PedidoItem;
using CaféPatronal.Programacao.Funcionario;
using CaféPatronal.Programacao.Pedido;
using CaféPatronal.Programacao.PedidoItem;
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

    
    public partial class CadastrarPedido : Form
    {
        BindingList<ProdutoDTO> produtos = new BindingList<ProdutoDTO>();
        decimal valordavenda = 0;
        Validação v = new Validação();
        public CadastrarPedido()
        {
            InitializeComponent();
            CarregarCombos();
        }
        void CarregarCombos()
        {

            ClienteBusiness buss = new ClienteBusiness();
            List<ClienteDTO> listas = buss.Listar();
            cmbClientes.ValueMember = nameof(ClienteDTO.id_cliente);
            cmbClientes.DisplayMember = nameof(ClienteDTO.nm_nome);
            cmbClientes.DataSource = listas;

            ProdutoBusiness busi = new ProdutoBusiness();
            List<ProdutoDTO> list = busi.Listar();
            cmbproduto.ValueMember = nameof(ProdutoDTO.id_produto);
            cmbproduto.DisplayMember = nameof(ProdutoDTO.nm_nome);
            cmbproduto.DataSource = list;

        }

        void verificar()
        {
            if (cmbClientes.Text == string.Empty)
            {
                MessageBox.Show("Escolha um cliente");
            }
            if (cmbForma.Text == string.Empty)
            {
                MessageBox.Show("Uma forma de pagamento");
            }


        }




        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();
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


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvarPedido_Click(object sender, EventArgs e)
        {
            try
            {

                ClienteDTO cliente = cmbClientes.SelectedItem as ClienteDTO;
                PedidoDTO dto = new PedidoDTO();
                dto.dt_venda = DateTime.Now;
                dto.ds_formapagamento = cmbForma.Text;
                dto.id_cliente = cliente.id_cliente;

                verificar();

                PedidoBusiness business = new PedidoBusiness();
                business.SalvarItem(dto, produtos.ToList());

                MessageBox.Show("Pedido salvo com sucesso.", "Café Patronal", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtquantidade.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Occoreu um erro " + ex.Message);
            }


        }

        private void txtquantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.numeros(e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoDTO produto = cmbproduto.SelectedItem as ProdutoDTO;
                for (int i = 0; i < Convert.ToInt32(txtquantidade.Text); i++)
                {
                    produtos.Add(produto);
                    valordavenda = valordavenda + produto.vl_produto;
                    dgvPedido.AutoGenerateColumns = false;
                    dgvPedido.DataSource = produtos;
                    lblvalortotal.Text = "R$ " + valordavenda.ToString();

                }
            }
            catch (Exception ex)
            {
                if (txtquantidade.Text == string.Empty)
                {
                    MessageBox.Show("Quantidade é obrigatória.");
                }
                else
                {
                    MessageBox.Show("Occoreu um erro " + ex.Message);
                }

            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            produtos = new BindingList<ProdutoDTO>();
            dgvPedido.AutoGenerateColumns = false;
            dgvPedido.DataSource = produtos;
            valordavenda = 0;
            lblvalortotal.Text = "R$ " + valordavenda.ToString();

            txtquantidade.Clear();

        }

        private void lblvalortotal_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarPedidos_Click(object sender, EventArgs e)
        {
            try
            {
                int b = 0;
                PedidoItemBusiness business = new PedidoItemBusiness();
                if (txtConsultapedidos.Text != string.Empty)
                {
                    b = Convert.ToInt32(txtConsultapedidos.Text);
                }
                if (b == 0)
                {
                    List<VwConsultarItem> g = business.ListarItem();
                    dgvConsultarPedidos.AutoGenerateColumns = false;
                    dgvConsultarPedidos.DataSource = g;
                }
                else
                {
                    List<VwConsultarItem> a = business.ConsultarItem(b);
                    dgvConsultarPedidos.AutoGenerateColumns = false;
                    dgvConsultarPedidos.DataSource = a;

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
                if (dgvConsultarPedidos.CurrentRow != null)
                {
                    VwConsultarItem pedido = dgvConsultarPedidos.CurrentRow.DataBoundItem as VwConsultarItem;
                    DialogResult r = MessageBox.Show("Deseja excluir esse pedido?", "Michael Pop`s",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        PedidoItemBusiness business = new PedidoItemBusiness();
                        business.Remover(pedido.id_pedido);

                        PedidoBusiness pedidobusiness = new PedidoBusiness();
                        pedidobusiness.Remover(pedido.id_pedido);
                        btnConsultarPedidos_Click(null, null);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
        }


        private void cmbClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validação v = new Validação();
            v.letras(e);
        }

    }
}

