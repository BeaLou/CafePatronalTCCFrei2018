using CaféPatronal.Programacao;
using CaféPatronal.Programacao.ControlePagamento;
using CaféPatronal.Programacao.FolhaPagamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaféPatronal.TELAS.Fluxo_de_Caixa_e_Folha_de_Pagamento
{
    public partial class Folha_de_Pagamento : Form
    {
        Validação V = new Validação();
        public Folha_de_Pagamento()
        {
            InitializeComponent();
        }

        private void txtInss_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.numeros(e);
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();
        }

        private void btnSalvarFolhaPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                FolhaPagamentoDTO dto = new FolhaPagamentoDTO();
                dto.ds_inss = Convert.ToDecimal(txtInss.Text);
                dto.ds_valealimentacao = Convert.ToDecimal(txtValeAlimentação.Text);
                dto.ds_valerefeicao = Convert.ToDecimal(txtValeRefeição.Text);
                dto.ds_valetransporte = Convert.ToDecimal(txtValeTransporte.Text);
                dto.ds_convenio = Convert.ToDecimal(txtConvênio.Text);
                dto.ds_agua = Convert.ToDecimal(txtAgua.Text);
                dto.ds_luz = Convert.ToDecimal(txtLuz.Text);

                FolhaPagamentoBusiness business = new FolhaPagamentoBusiness();
                business.Salvar(dto);
                MessageBox.Show("Folha de pagamento salva.");
                txtInss.Text = "";
                txtValeAlimentação.Text = "";
                txtValeRefeição.Text = "";
                txtValeTransporte.Text = "";
                txtConvênio.Text = "";
                txtAgua.Text = "";
                txtLuz.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex.Message);
            }
        }

        private void btnSalvarControle_Click(object sender, EventArgs e)
        {
            try
            {
                CpDTO dto = new CpDTO();
                dto.dia = dtpDia.Value;
                dto.horaentrada = Convert.ToDateTime(txtHrEntrada.Text);
                dto.horasaida = Convert.ToDateTime(txtHrSaida.Text);
                dto.horaalmoco = Convert.ToDateTime(txthralmoco.Text);
                dto.horaretornoalmoco = Convert.ToDateTime(txtretoralmoco.Text);
                dto.horaextra = Convert.ToDateTime(txtHrExtra.Text);
                dto.horasaidahoraextra = Convert.ToDateTime(txthrex.Text);

                CpBusiness business = new CpBusiness();
                business.Salvar(dto);
                MessageBox.Show("Controle de pagamento salvo.");
                txtHrEntrada.Text = "";
                txtHrSaida.Text = "";
                txthralmoco.Text = "";
                txtretoralmoco.Text = "";
                txtHrExtra.Text = "";
                txthrex.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex.Message);
            }
        }
    }
}
