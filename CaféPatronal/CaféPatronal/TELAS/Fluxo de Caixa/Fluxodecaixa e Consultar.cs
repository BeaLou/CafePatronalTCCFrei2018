using CaféPatronal.Programacao.FluxoCaixa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaféPatronal.TELAS
{
    public partial class Consulta_de_Fluxo_de_Caixa : Form
    {
        public Consulta_de_Fluxo_de_Caixa()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();
        }

        private void dgvFluxodCaixa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();
        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnConsularFluxo_Click(object sender, EventArgs e)
        {

            try
            {
                FluxoCaixaBusiness business = new FluxoCaixaBusiness();
                List<FluxoCaixaVw> lista = business.Consultar(dtpInicio.Value, dtpFim.Value);

                dgvFluxo.AutoGenerateColumns = false;
                dgvFluxo.DataSource = lista;
                decimal saldo = 0;
                foreach (FluxoCaixaVw item in lista)
                {
                    saldo = saldo + item.Lucro;
                }

                lblSaldo.Text = "R$ " + saldo.ToString();
                if (saldo < 0)
                {
                    lblSaldo.ForeColor = Color.Red;
                }
                else
                {
                    lblSaldo.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }


        }
    }
}
