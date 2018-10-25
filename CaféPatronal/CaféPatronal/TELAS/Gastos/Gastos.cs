using CaféPatronal.Programacao;
using CaféPatronal.Programacao.Entregável_4.Gastos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaféPatronal.TELAS.Gastos
{
    public partial class Gastos : Form
    {
        Validação v = new Validação();
        public Gastos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();
        }

        private void BtnSalvarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                GastoDTO dto = new GastoDTO();

                dto.Gasto = txtnome.Text;
                dto.Tipo = cboTipo.SelectedItem.ToString();
                dto.Pagamento = dtpdata.Value;
                dto.Valor = Convert.ToDecimal(txtvalor.Text);

                GastoBusiness business = new GastoBusiness();
                business.Salvar(dto);
                MessageBox.Show("Gasto salvo com sucesso");
                txtnome.Clear();
                txtvalor.Clear();
                dtpdata.Value = DateTime.Now;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu o erro : " + ex.Message);
            }
        }

        private void btnConsultarestoque_Click(object sender, EventArgs e)
        {
            GastoBusiness business = new GastoBusiness();
            List<GastoDTO> a =business.Consultar(txtConsultarEstoque.Text);
            dgvconsultaestoq.AutoGenerateColumns = false;
            dgvconsultaestoq.DataSource = a;
        }

        private void txtnome_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.letras(e);
        }

        private void txtvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.numeros(e);
        }
    }
}
