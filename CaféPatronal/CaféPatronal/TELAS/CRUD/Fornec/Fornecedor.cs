using CaféPatronal.Programacao;
using CaféPatronal.Programacao.Estoque;
using CaféPatronal.TELAS.CRUD.Fornec;
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
    public partial class CadastrarFornecedor : Form
    {
        Validação V = new Validação();
        public CadastrarFornecedor()
        {
            InitializeComponent();
        }

        private void CadastrarFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.letras(e);
        }

        private void mktCpf_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvConsultarFornecedor.CurrentRow != null)
                {
                    FornecedorDTO fornecedor = dgvConsultarFornecedor.CurrentRow.DataBoundItem as FornecedorDTO;

                    AlterarFornecedor tela = new AlterarFornecedor();
                    tela.LoadScreen(fornecedor);
                    tela.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Selecione um Fornecedor");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void btnSalvarFornecedores_Click(object sender, EventArgs e)
        {
            try
            {
                FornecedorDTO dto = new FornecedorDTO();
                dto.nm_nome = txtNomeFornec.Text;
                dto.ds_cnpj = mktCnpj.Text;
                dto.ds_telefone = mktTelefoneFixo.Text;
                dto.ds_cep = mtbCep.Text;
                dto.ds_complemento = txtComplemento.Text;
                dto.ds_numerofornecedor = txtNumero.Text;
                dto.ds_email = txtemail.Text;

                FOrnecedorBusiness business = new FOrnecedorBusiness();
                business.Salvar(dto);
                MessageBox.Show("Fornecedor salvo com sucesso.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex.Message);
            }
        }

        private void btnConsultarFornece_Click(object sender, EventArgs e)
        {
            FOrnecedorBusiness business = new FOrnecedorBusiness();
            List<FornecedorDTO> a = business.Consultar(txtconsultar.Text);
            dgvConsultarFornecedor.AutoGenerateColumns = false;
            dgvConsultarFornecedor.DataSource = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvConsultarFornecedor.CurrentRow != null)
                {
                    FornecedorDTO fornecedor = dgvConsultarFornecedor.CurrentRow.DataBoundItem as FornecedorDTO;
                    DialogResult r = MessageBox.Show("Deseja excluir esse fornecedor?", "Michael Pop`s",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        FOrnecedorBusiness business = new FOrnecedorBusiness();
                        business.Remover(fornecedor.id_fornecedor);

                        List<FornecedorDTO> a = business.Consultar(txtconsultar.Text);
                        dgvConsultarFornecedor.AutoGenerateColumns = false;
                        dgvConsultarFornecedor.DataSource = a;

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

        private void mktTelefoneFixo_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.numeros(e);
        }

        private void mtbCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.numeros(e);
        }
    }
}
