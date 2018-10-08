using CaféPatronal.Programacao;
using CaféPatronal.Programacao.FolhaPagamento;
using CaféPatronal.Programacao.Funcionario;
using CaféPatronal.Programacao.Objetos;
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
        FolhaPagamento folhapagamento = new FolhaPagamento();
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
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int ht = Convert.ToInt32(nudHorasTrabalhadas.Value);
            int he = Convert.ToInt32(nudHorasExtras.Value);
            decimal porcentagem = nudPorcentagem.Value;
            int diastrabalhados = folhapagamento.CalcularDiasTrabalhados(Convert.ToInt32(txtFaltasPriSemana.Text), Convert.ToInt32(txtFaltaSegSemana.Text), Convert.ToInt32(txtFaltaTerSemana.Text), Convert.ToInt32(txtFaltaQuarSemana.Text));
            int finaisdesemana = folhapagamento.CalcularFinaisdeSemanas(Convert.ToInt32(txtFaltasPriSemana.Text), Convert.ToInt32(txtFaltaSegSemana.Text), Convert.ToInt32(txtFaltaTerSemana.Text), Convert.ToInt32(txtFaltaQuarSemana.Text));
            int totaldefaltas = folhapagamento.CalcularTotalDeFaltas(Convert.ToInt32(txtFaltasPriSemana.Text), Convert.ToInt32(txtFaltaSegSemana.Text), Convert.ToInt32(txtFaltaTerSemana.Text), Convert.ToInt32(txtFaltaQuarSemana.Text));

            FuncionarioDTO funcionario = cboFuncionario.SelectedItem as FuncionarioDTO;
            SalarioBruto = funcionario.vl_salariobruto;

            if (nudHorasExtras.Value > 0 && chkVT.Checked == true)
            {
                decimal valorporhora = folhapagamento.CalcularValorPorHora(SalarioBruto, ht);
                decimal totalhorasextras = folhapagamento.CalcularValorHoraExtra(valorporhora, porcentagem, he);
                DSR = folhapagamento.CalcularDSR(totalhorasextras, diastrabalhados, finaisdesemana);
                decimal TotalSalarioBruto = SalarioBruto + totalhorasextras + DSR;



                INSS = folhapagamento.CalcularINSS(SalarioBruto, TotalSalarioBruto);
                IR = folhapagamento.CalcularIR(TotalSalarioBruto, INSS);
                FGTS = folhapagamento.CalcularFGTS(TotalSalarioBruto);
                VT = SalarioBruto * 0.06m;

                SalarioLiquido = SalarioBruto + totalhorasextras + DSR - INSS - folhapagamento.ValordeDesconto - VT;

                lblText.Visible = true;
                lblSalarioLiquido.Visible = true;
                lblSalarioLiquido.Text = "R$ " + Decimal.Round(SalarioLiquido).ToString();

            }
            else if (nudHorasExtras.Value > 0 && chkVT.Checked == false)
            {
                decimal valorporhora = folhapagamento.CalcularValorPorHora(SalarioBruto, ht);
                decimal totalhorasextras = folhapagamento.CalcularValorHoraExtra(valorporhora, porcentagem, he);
                DSR = folhapagamento.CalcularDSR(totalhorasextras, diastrabalhados, finaisdesemana);
                decimal TotalSalarioBruto = SalarioBruto + totalhorasextras + DSR;



                INSS = folhapagamento.CalcularINSS(SalarioBruto, TotalSalarioBruto);
                IR = folhapagamento.CalcularIR(TotalSalarioBruto, INSS);
                FGTS = folhapagamento.CalcularFGTS(TotalSalarioBruto);


                decimal SalarioLiquido = SalarioBruto + totalhorasextras + DSR - INSS - folhapagamento.ValordeDesconto - VT;

                lblText.Visible = true;
                lblSalarioLiquido.Visible = true;
                lblSalarioLiquido.Text = "R$ " + Decimal.Round(SalarioLiquido).ToString();
            }
            else if (nudHorasExtras.Value == 0 && chkVT.Checked == true)
            {

                decimal descontodosalariobruto = SalarioBruto / 30 * totaldefaltas;
                SalarioBruto = SalarioBruto - descontodosalariobruto;

                decimal valorporhora = folhapagamento.CalcularValorPorHora(SalarioBruto, ht);

                INSS = folhapagamento.CalcularINSS(SalarioBruto, SalarioBruto);
                IR = folhapagamento.CalcularIR(SalarioBruto, INSS);
                FGTS = folhapagamento.CalcularFGTS(SalarioBruto);
                VT = SalarioBruto * 0.06m;

                SalarioLiquido = SalarioBruto - INSS - folhapagamento.ValordeDesconto - VT;

                lblText.Visible = true;
                lblSalarioLiquido.Visible = true;
                lblSalarioLiquido.Text = "R$ " + Decimal.Round(SalarioLiquido).ToString();
            }

            else if (nudHorasExtras.Value == 0 && chkVT.Checked == false)
            {
                decimal descontodosalariobruto = SalarioBruto / 30 * totaldefaltas;
                SalarioBruto = SalarioBruto - descontodosalariobruto;

                decimal valorporhora = folhapagamento.CalcularValorPorHora(SalarioBruto, ht);

                INSS = folhapagamento.CalcularINSS(SalarioBruto, SalarioBruto);
                IR = folhapagamento.CalcularIR(SalarioBruto, INSS);
                FGTS = folhapagamento.CalcularFGTS(SalarioBruto);

                SalarioLiquido = SalarioBruto - INSS - folhapagamento.ValordeDesconto - VT;

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
