using CaféPatronal.Programacao;
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

namespace CaféPatronal.TELAS.CRUD.Produ
{
    public partial class AlterarProduto : Form
    {
        Validação v = new Validação();
        ProdutoDTO produto;
        public AlterarProduto()
        {
            InitializeComponent();
        }
        public void LoadScreen(ProdutoDTO produto)
        {
            this.produto = produto;
            TxtNomeProduto.Text = produto.nm_nome;
            txtUnidade.Text = produto.ds_descricao;
            txtVlProduto.Text = Convert.ToString(produto.vl_produto);


        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            CadastrarProduto tela = new CadastrarProduto();
            tela.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.letras(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                produto.nm_nome = TxtNomeProduto.Text;
                produto.ds_descricao = txtUnidade.Text;
                produto.vl_produto = Convert.ToDecimal(txtVlProduto.Text);



                ProdutoBusiness business = new ProdutoBusiness();
                business.Alterar(produto);


                MessageBox.Show("Produto alterado com sucesso");

                CadastrarProduto tela = new CadastrarProduto();
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
