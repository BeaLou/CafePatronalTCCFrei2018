using CaféPatronal.Programacao;
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
    }
}
