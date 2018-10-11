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
    }
}
