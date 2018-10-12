
using CaféPatronal.Programacao;
using CaféPatronal.TELAS;
using CaféPatronal.TELAS.Cadastro_e_Consulta;
using CaféPatronal.TELAS.Compra;
using CaféPatronal.TELAS.Consulta;
using CaféPatronal.TELAS.Fluxo_de_Caixa_e_Folha_de_Pagamento;
using CaféPatronal.TELAS.MenuHistoriaSplash;
using System;
using System.Windows.Forms;

namespace CaféPatronal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            VerificarPermissoes();
        }
        void VerificarPermissoes()
        {
            if (UserSession.UsuarioLogado.bt_permissaoadm == false)
            {
                if (UserSession.UsuarioLogado.bt_permissaofuncionario == true)
                {
                    BtnFolhaPagamento.Enabled = false;
                    BtnFornecedor.Enabled = false;
                    BtnVenda.Enabled = false;
                    BtnEstoque.Enabled = false;
                    BtnFluxoCaixa.Enabled = false;


                }
            }
        }






        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você quer mesmo sair?", "Café Patronal",
MessageBoxButtons.YesNo, MessageBoxIcon.Question)
== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Sobre tela = new Sobre();
            tela.Show();
            this.Hide();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Folha_de_Pagamento tela = new Folha_de_Pagamento();
            tela.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Historia tela = new Historia();
            tela.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro_de_Clientes tela = new Cadastro_de_Clientes();
            tela.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastroFuncionario tela = new CadastroFuncionario();
            tela.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CadastrarPedido tela = new CadastrarPedido();
            tela.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CadastrarProduto tela = new CadastrarProduto();
            tela.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CadastrarFornecedor tela = new CadastrarFornecedor();
            tela.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Consulta_de_Estoque tela = new Consulta_de_Estoque();
            tela.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Consulta_de_Fluxo_de_Caixa tela = new Consulta_de_Fluxo_de_Caixa();
            tela.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ControleDeVenda tela = new ControleDeVenda();
            tela.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login tela = new Login();
            tela.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CadastroCompra tela = new CadastroCompra();
            tela.Show();
            this.Hide();
        }
    }
}
