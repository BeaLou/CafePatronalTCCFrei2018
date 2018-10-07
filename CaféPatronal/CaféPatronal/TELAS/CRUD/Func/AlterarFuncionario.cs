using CaféPatronal.Programacao;
using CaféPatronal.Programacao.Funcionario;
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

namespace CaféPatronal.TELAS.CRUD.Func
{
    public partial class AlterarFuncionario : Form
    {
        Validação v = new Validação();
        FuncionarioDTO funcionario;
        public AlterarFuncionario()
        {
            InitializeComponent();
        }
         public void LoadScreen(FuncionarioDTO funcionario)
        {
            this.funcionario = funcionario;

            txtnome.Text = funcionario.nm_nome;
            txtsobrenome.Text = funcionario.nm_sobrenome;
            txtcpf.Text = funcionario.ds_cpf;
            txtrg.Text = funcionario.ds_rg;
            dtpnascimento.Value = funcionario.dt_nascimento;
            txtemail.Text = funcionario.ds_email;
            txtlogin.Text = funcionario.ds_login;
            txtsenha.Text = funcionario.ds_senha;
            cbodepartamento.Text = funcionario.ds_dpto;
            txtcarteiratrabalho.Text = funcionario.ds_carteiratrabalho;
            txttelefone.Text = funcionario.ds_telefone;
            txttelmovel.Text = funcionario.ds_telefonemovel;
            txtcep.Text = funcionario.ds_cep;
            txtcomplemento.Text = funcionario.ds_complemento;
            txtncasa.Text = funcionario.ds_ncasa;



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CadastroFuncionario tela = new CadastroFuncionario();
            tela.Show();
            this.Hide();
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.letras(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.letras(e);
        }

        private void maskedTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.numeros(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                funcionario.nm_nome = txtnome.Text;
                funcionario.nm_sobrenome = txtsobrenome.Text;
                funcionario.ds_cpf = txtcpf.Text;
                funcionario.ds_rg = txtrg.Text;
                funcionario.dt_nascimento = dtpnascimento.Value;
                funcionario.ds_email = txtemail.Text;
                funcionario.ds_login = txtlogin.Text;
                funcionario.ds_senha = txtsenha.Text;
                funcionario.ds_dpto = cbodepartamento.Text;
                funcionario.ds_carteiratrabalho = txtcarteiratrabalho.Text;
                funcionario.ds_telefone = txttelefone.Text;
                funcionario.ds_telefonemovel = txttelmovel.Text;
                funcionario.ds_cep = txtcep.Text;
                funcionario.ds_complemento = txtcomplemento.Text;
                funcionario.ds_ncasa = txtncasa.Text;
                funcionario.vl_salariobruto = Convert.ToDecimal(txtsalariobruto.Text);

                FuncionarioBusiness business = new FuncionarioBusiness();
                business.Alterar(funcionario);


                MessageBox.Show("Funcionário alterado com sucesso");

                CadastroFuncionario tela = new CadastroFuncionario();
                tela.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
