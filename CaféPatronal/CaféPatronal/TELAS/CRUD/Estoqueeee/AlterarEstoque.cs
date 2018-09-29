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

namespace CaféPatronal.TELAS.CRUD.Estoqueeee
{
    public partial class AlterarEstoque : Form
    {
        Validação v = new Validação();
        public AlterarEstoque()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Consulta_de_Estoque tela = new Consulta_de_Estoque();
            tela.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.numeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
