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

namespace CaféPatronal.TELAS.CRUD.Clientesss
{
    public partial class AlterarCliente : Form
    {
        Validação v = new Validação();
        public AlterarCliente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Cadastro_de_Clientes tela = new Cadastro_de_Clientes();
            tela.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.letras(e);
        }
    }
}
