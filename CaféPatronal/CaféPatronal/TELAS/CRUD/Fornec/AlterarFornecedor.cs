using CaféPatronal.Programacao;
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

namespace CaféPatronal.TELAS.CRUD.Fornec
{
    public partial class AlterarFornecedor : Form
    {
        Validação v = new Validação();
        FornecedorDTO fornecedor;
        public AlterarFornecedor()
        {
            InitializeComponent();
        }
        public void LoadScreen(FornecedorDTO fornecedor)
        {
            this.fornecedor = fornecedor;
            txtnome.Text = fornecedor.nm_nome;
            txtcnpj.Text = fornecedor.ds_cnpj;
            txttelefone.Text = fornecedor.ds_telefone;
            txtcep.Text = fornecedor.ds_cep;
            txtcomplemento.Text = fornecedor.ds_complemento;
            txtnumero.Text = fornecedor.ds_numerofornecedor;
            txtemail.Text = fornecedor.ds_email;






        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CadastrarFornecedor tela = new CadastrarFornecedor();
            tela.Show();
            this.Hide();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.letras(e);
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.numeros(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                fornecedor.nm_nome = txtnome.Text;
                fornecedor.ds_cnpj = txtcnpj.Text;
                fornecedor.ds_telefone = txttelefone.Text;
                fornecedor.ds_cep = txtcep.Text;
                fornecedor.ds_complemento = txtcomplemento.Text;
                fornecedor.ds_numerofornecedor = txtnumero.Text;
                fornecedor.ds_email = txtemail.Text;

                FOrnecedorBusiness business = new FOrnecedorBusiness();
                business.Alterar(fornecedor);


                MessageBox.Show("Fornecedor alterado com sucesso");

                CadastrarFornecedor tela = new CadastrarFornecedor();
                tela.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }
    }
}
