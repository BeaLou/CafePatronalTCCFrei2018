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

namespace CaféPatronal.TELAS.CRUD.Func
{
    public partial class AlterarFuncionario : Form
    {
        Validação v = new Validação();
        public AlterarFuncionario()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CadastroFuncionario tela = new CadastroFuncionario();
            tela.Show();
            this.Hide();
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.letras(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.letras(e);
        }

        private void maskedTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.numeros(e);
        }
    }
}
