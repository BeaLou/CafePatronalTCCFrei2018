using CaféPatronal.Programacao;
using CaféPatronal.Programacao.ControlePagamento;
using CaféPatronal.Programacao.FolhaPagamento;
using CaféPatronal.Programacao.Funcionario;
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
            lblText.Visible = false;
            lblSalarioLiquido.Visible = false;

            lblPorcentagem.Visible = false;
            nudPorcentagem.Visible = false;
            lblHoraExtra.Visible = false;
            nudHorasExtras.Visible = false;
            CarregarCombo();
        }
        decimal ValordeDesconto;
        void CarregarCombo()
        {
            FuncionarioBusiness business = new FuncionarioBusiness();
            List<FuncionarioDTO> Funcionarios = business.Listar();

            cboFuncionario.ValueMember = nameof(FuncionarioDTO.id_funcionario);
            cboFuncionario.DisplayMember = nameof(FuncionarioDTO.nm_nome);
            cboFuncionario.DataSource = Funcionarios;

        }
        decimal VT = 0;
        decimal SalarioBruto = 0;
        decimal DSR;
        decimal INSS;
        decimal IR;
        decimal FGTS;
        decimal SalarioLiquido;

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
                FuncionarioDTO funcionario = cboFuncionario.SelectedItem as FuncionarioDTO;

                dto.ds_mes = cbmes.Text;
                dto.bt_valetransporte = chkVT.Checked;
                dto.vl_fgts = FGTS;
                dto.hr_horasextras = Convert.ToInt32(nudHorasExtras.Value);
                dto.vl_inss = INSS;
                dto.vl_ir = IR;
                dto.vl_salarioliquido = Decimal.Round(SalarioLiquido);
                dto.vl_ValeTransporte = VT;
                dto.id_funcionario = funcionario.id_funcionario;

                FolhaPagamentoBusiness business = new FolhaPagamentoBusiness();
                business.Salvar(dto);
                MessageBox.Show("Folha de pagamento salva com sucesso");
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
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro " + ex.Message);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int ht = Convert.ToInt32(nudHorasTrabalhadas.Value);
            int he = Convert.ToInt32(nudHorasExtras.Value);
            decimal porcentagem = nudPorcentagem.Value;
            int diastrabalhados = CalcularDiasTrabalhados(Convert.ToInt32(txtFaltasPriSemana.Text), Convert.ToInt32(txtFaltaSegSemana.Text), Convert.ToInt32(txtFaltaTerSemana.Text), Convert.ToInt32(txtFaltaQuarSemana.Text));
            int finaisdesemana = CalcularFinaisdeSemanas(Convert.ToInt32(txtFaltasPriSemana.Text), Convert.ToInt32(txtFaltaSegSemana.Text), Convert.ToInt32(txtFaltaTerSemana.Text), Convert.ToInt32(txtFaltaQuarSemana.Text));
            int totaldefaltas = CalcularTotalDeFaltas(Convert.ToInt32(txtFaltasPriSemana.Text), Convert.ToInt32(txtFaltaSegSemana.Text), Convert.ToInt32(txtFaltaTerSemana.Text), Convert.ToInt32(txtFaltaQuarSemana.Text));

            FuncionarioDTO funcionario = cboFuncionario.SelectedItem as FuncionarioDTO;
            SalarioBruto = funcionario.vl_salariobruto;

            if (nudHorasExtras.Value > 0 && chkVT.Checked == true)
            {
                decimal valorporhora = CalcularValorPorHora(SalarioBruto, ht);
                decimal totalhorasextras = CalcularValorHoraExtra(valorporhora, porcentagem, he);
                DSR = CalcularDSR(totalhorasextras, diastrabalhados, finaisdesemana);
                decimal TotalSalarioBruto = SalarioBruto + totalhorasextras + DSR;



                INSS = CalcularINSS(SalarioBruto, TotalSalarioBruto);
                IR = CalcularIR(TotalSalarioBruto, INSS);
                FGTS = CalcularFGTS(TotalSalarioBruto);
                VT = SalarioBruto * 0.06m;

                SalarioLiquido = SalarioBruto + totalhorasextras + DSR - INSS - ValordeDesconto - VT;

                lblText.Visible = true;
                lblSalarioLiquido.Visible = true;
                lblSalarioLiquido.Text = "R$ " + Decimal.Round(SalarioLiquido).ToString();

            }
            else if (nudHorasExtras.Value > 0 && chkVT.Checked == false)
            {
                decimal valorporhora = CalcularValorPorHora(SalarioBruto, ht);
                decimal totalhorasextras = CalcularValorHoraExtra(valorporhora, porcentagem, he);
                DSR = CalcularDSR(totalhorasextras, diastrabalhados, finaisdesemana);
                decimal TotalSalarioBruto = SalarioBruto + totalhorasextras + DSR;



                INSS = CalcularINSS(SalarioBruto, TotalSalarioBruto);
                IR = CalcularIR(TotalSalarioBruto, INSS);
                FGTS = CalcularFGTS(TotalSalarioBruto);


                decimal SalarioLiquido = SalarioBruto + totalhorasextras + DSR - INSS - ValordeDesconto - VT;

                lblText.Visible = true;
                lblSalarioLiquido.Visible = true;
                lblSalarioLiquido.Text = "R$ " + Decimal.Round(SalarioLiquido).ToString();
            }
            else if (nudHorasExtras.Value == 0 && chkVT.Checked == true)
            {

                decimal descontodosalariobruto = SalarioBruto / 30 * totaldefaltas;
                SalarioBruto = SalarioBruto - descontodosalariobruto;

                decimal valorporhora = CalcularValorPorHora(SalarioBruto, ht);

                INSS = CalcularINSS(SalarioBruto, SalarioBruto);
                IR = CalcularIR(SalarioBruto, INSS);
                FGTS = CalcularFGTS(SalarioBruto);
                VT = SalarioBruto * 0.06m;

                SalarioLiquido = SalarioBruto - INSS - ValordeDesconto - VT;

                lblText.Visible = true;
                lblSalarioLiquido.Visible = true;
                lblSalarioLiquido.Text = "R$ " + Decimal.Round(SalarioLiquido).ToString();
            }

            else if (nudHorasExtras.Value == 0 && chkVT.Checked == false)
            {
                decimal descontodosalariobruto = SalarioBruto / 30 * totaldefaltas;
                SalarioBruto = SalarioBruto - descontodosalariobruto;

                decimal valorporhora = CalcularValorPorHora(SalarioBruto, ht);

                INSS = CalcularINSS(SalarioBruto, SalarioBruto);
                IR = CalcularIR(SalarioBruto, INSS);
                FGTS = CalcularFGTS(SalarioBruto);

                SalarioLiquido = SalarioBruto - INSS - ValordeDesconto - VT;

                lblText.Visible = true;
                lblSalarioLiquido.Visible = true;
                lblSalarioLiquido.Text = "R$ " + Decimal.Round(SalarioLiquido).ToString();
            }
        }

        private void chkHoraExtra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHoraExtra.Checked == true)
            {
                lblPorcentagem.Visible = true;
                nudPorcentagem.Visible = true;
                lblHoraExtra.Visible = true;
                nudHorasExtras.Visible = true;
            }

            if (chkHoraExtra.Checked == false)
            {
                lblPorcentagem.Visible = false;
                nudPorcentagem.Visible = false;
                lblHoraExtra.Visible = false;
                nudHorasExtras.Visible = false;
            }
        }
        decimal CalcularValorPorHora(decimal SalarioBruto, int HorasTrabalhadas)
        {
            decimal resposta = SalarioBruto / HorasTrabalhadas;

            return resposta;
        }

        decimal CalcularValorHoraExtra(decimal ValorDaHora, decimal Porcentagem, int horasextras)
        {
            decimal Horaextra = (ValorDaHora * (Porcentagem / 100)) + ValorDaHora;

            Horaextra = horasextras * Horaextra;

            return Horaextra;
        }

        int CalcularDiasTrabalhados(int Faltas1semana, int faltas2semana, int Faltas3semana, int Faltas4semana)
        {
            if (Faltas1semana > 0)
            {
                Faltas1semana = Faltas1semana + 1;
            }
            if (faltas2semana > 0)
            {
                faltas2semana = faltas2semana + 1;
            }
            if (Faltas3semana > 0)
            {
                Faltas3semana = Faltas3semana + 1;
            }
            if (Faltas4semana > 0)
            {
                Faltas4semana = Faltas4semana + 1;
            }


            int totaldefaltas = Faltas1semana + faltas2semana + Faltas3semana + Faltas4semana;
            int diastrabalhados = 26 - totaldefaltas;

            return diastrabalhados;
        }

        int CalcularFinaisdeSemanas(int Faltas1semana, int faltas2semana, int Faltas3semana, int Faltas4semana)
        {
            int finaisdesemanaperdido = 0;


            if (Faltas1semana == 0)
            {
                finaisdesemanaperdido = finaisdesemanaperdido + 1;
            }
            if (faltas2semana == 0)
            {
                finaisdesemanaperdido = finaisdesemanaperdido + 1;
            }
            if (Faltas3semana == 0)
            {
                finaisdesemanaperdido = finaisdesemanaperdido + 1;
            }
            if (Faltas4semana == 0)
            {
                finaisdesemanaperdido = finaisdesemanaperdido + 1;
            }

            return finaisdesemanaperdido;
        }


        decimal CalcularDSR(decimal TotalHorasExtras, int DiasTrabalhados, int FinaisDeSemana)
        {
            decimal DSR = TotalHorasExtras / DiasTrabalhados * FinaisDeSemana;

            return DSR;
        }

        decimal CalcularINSS(decimal SalarioBruto, decimal TotalSalarioBruto)
        {
            decimal PorcentagemINSS = 0;
            if (SalarioBruto <= 1693.72m)
            {
                PorcentagemINSS = 8;
            }
            if (SalarioBruto >= 1693.73m && SalarioBruto <= 2822.90m)
            {
                PorcentagemINSS = 9;
            }
            if (SalarioBruto >= 2822.91m && SalarioBruto <= 5645.80m)
            {
                PorcentagemINSS = 11;
            }

            decimal INSS = TotalSalarioBruto * (PorcentagemINSS / 100);

            return INSS;
        }

        decimal CalcularIR(decimal TotalSalarioBruto, decimal ValorINSS)
        {
            decimal PorcentagemIR = 0;

            TotalSalarioBruto = TotalSalarioBruto - ValorINSS;

            if (TotalSalarioBruto >= 1903.99m && TotalSalarioBruto <= 2826.65m)
            {
                PorcentagemIR = 7.5m;
                ValordeDesconto = 142.80m;
            }
            if (TotalSalarioBruto >= 2826.66m && TotalSalarioBruto <= 3751.05m)
            {
                PorcentagemIR = 15;
                ValordeDesconto = 354.80m;
            }
            if (TotalSalarioBruto >= 3751.06m && TotalSalarioBruto <= 4664.68m)
            {
                PorcentagemIR = 22.5m;
                ValordeDesconto = 636.13m;
            }
            if (TotalSalarioBruto > 4664.69m)
            {
                PorcentagemIR = 27.5m;
                ValordeDesconto = 869.36m;
            }

            decimal valordescontado = TotalSalarioBruto * (PorcentagemIR / 100);
            decimal IR = valordescontado - ValordeDesconto;

            return IR;
        }

        decimal CalcularFGTS(decimal SalarioBrutoTotal)
        {
            decimal FGTS = SalarioBrutoTotal * 0.08m;
            return FGTS;
        }

        int CalcularTotalDeFaltas(int Faltas1semana, int faltas2semana, int Faltas3semana, int Faltas4semana)
        {
            int finaisdesemanaperdido = 0;


            if (Faltas1semana > 0)
            {
                finaisdesemanaperdido = finaisdesemanaperdido + 1;
            }
            if (faltas2semana > 0)
            {
                finaisdesemanaperdido = finaisdesemanaperdido + 1;
            }
            if (Faltas3semana > 0)
            {
                finaisdesemanaperdido = finaisdesemanaperdido + 1;
            }
            if (Faltas4semana > 0)
            {
                finaisdesemanaperdido = finaisdesemanaperdido + 1;
            }

            int totalfaltas = Faltas1semana + faltas2semana + Faltas3semana + Faltas4semana + finaisdesemanaperdido;
            return totalfaltas;

        }

        private void lblSalarioLiquido_Click(object sender, EventArgs e)
        {

        }

        private void chkVT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FolhaPagamentoBusiness business = new FolhaPagamentoBusiness();
            List<VwConsultarFolhapagamento> a = business.Consultarmes(txtConsultarFolha.Text);
            dgvConsultarFolha.AutoGenerateColumns = false;
            dgvConsultarFolha.DataSource = a;
        }
    }
}
