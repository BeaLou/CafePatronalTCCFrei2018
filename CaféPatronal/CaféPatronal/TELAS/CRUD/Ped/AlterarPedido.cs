using CaféPatronal.Programacao;
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

namespace CaféPatronal.TELAS.CRUD.Ped
{
    public partial class AlterarPedido : Form
    {
        Validação v = new Validação();
        public AlterarPedido()
        {
            InitializeComponent();
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.letras(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.numeros(e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CadastrarPedido tela = new CadastrarPedido();
            tela.Show();
            this.Hide();
        }
    }
}
