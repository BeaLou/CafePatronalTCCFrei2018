using CaféPatronal.Programacao;
using CaféPatronal.Programacao.Dpto;
using CaféPatronal.Programacao.Funcionario;
using CaféPatronal.TELAS.CRUD.Func;
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
    public partial class CadastroFuncionario : Form
    {
        Validação V = new Validação();
        public CadastroFuncionario()
        {
            InitializeComponent();
            VerificarPermissoes();
            CarregarCombos();
        }

        void CarregarCombos()
        {
            DptoBusiness bus = new DptoBusiness();
            List<DptoDTO> lista = bus.Listar();
            cboDepartamento.DisplayMember = nameof(DptoDTO.nm_nome);
            cboDepartamento.DataSource = lista;
        }
        void VerificarPermissoes()
        {
            if (UserSession.UsuarioLogado.bt_permissaoadm == false)
            {
                btnAlterar.Enabled = false;


            }
        }


        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
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

        private void lblRg_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();
        }

        private void btnSalvarFuncionário_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioDTO dto = new FuncionarioDTO();
                dto.nm_nome = txtNome.Text;
                dto.nm_sobrenome = txtSobrenome.Text;
                dto.ds_cpf = mbtCpf.Text;
                dto.ds_rg = mbtRg.Text;
                dto.dt_nascimento = dtpDataNascimento.Value;
                dto.ds_email = txtEmail.Text;
                dto.ds_login = txtLogin.Text;
                dto.ds_senha = txtSenha.Text;
                dto.ds_dpto = cboDepartamento.Text;
                dto.ds_carteiratrabalho = mbtCarteiraTrabalho.Text;
                dto.ds_telefone = mtbTelefoneFixo.Text;
                dto.ds_telefonemovel = mtbTelefoneMovel.Text;
                dto.ds_cep = mtbCep.Text;
                dto.ds_complemento = txtComplemento.Text;
                dto.ds_ncasa = txtNumero.Text;


                FuncionarioBusiness business = new FuncionarioBusiness();
                business.Salvar(dto);
                MessageBox.Show("Funcionário salvo com sucesso!");
                txtNome.Text = "";
                txtSobrenome.Text = "";
                mbtCpf.Text = "";
                mbtRg.Text = "";
                txtEmail.Text = "";
                txtLogin.Text = "";
                txtSenha.Text = "";
                cboDepartamento.Text = "";
                mbtCarteiraTrabalho.Text = "";
                mtbTelefoneFixo.Text = "";
                mtbTelefoneMovel.Text = "";
                mtbCep.Text = "";
                txtComplemento.Text = "";
                txtNumero.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex.Message);
            }

        }

        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            FuncionarioBusiness business = new FuncionarioBusiness();
            List<FuncionarioDTO> a = business.Consultar(txtConsultarFuncionários.Text);
            dgvConsultarFuncionarios.AutoGenerateColumns = false;
            dgvConsultarFuncionarios.DataSource = a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                FuncionarioDTO funcionario = dgvConsultarFuncionarios.CurrentRow.DataBoundItem as FuncionarioDTO;

                AlterarFuncionario tela = new AlterarFuncionario();
                tela.LoadScreen(funcionario);
                tela.Show();
                this.Hide();



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
                FuncionarioDTO funcionario = dgvConsultarFuncionarios.CurrentRow.DataBoundItem as FuncionarioDTO;
                DialogResult r = MessageBox.Show("Deseja excluir esse funcionário?", "Michael Pop`s",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    FuncionarioBusiness business = new FuncionarioBusiness();
                    business.Remover(funcionario.id_funcionario);

                    List<FuncionarioDTO> a = business.Consultar(txtConsultarFuncionários.Text);
                    dgvConsultarFuncionarios.AutoGenerateColumns = false;
                    dgvConsultarFuncionarios.DataSource = a;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }
    }
}
