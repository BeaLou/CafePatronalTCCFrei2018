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

namespace CaféPatronal.TELAS
{
    public partial class Consulta_de_Estoque : Form
    {
        Validação V = new Validação();
        public Consulta_de_Estoque()
        {
            InitializeComponent();
        }

        private void Consulta_de_Estoque_Load(object sender, EventArgs e)
        {

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.numeros(e);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
