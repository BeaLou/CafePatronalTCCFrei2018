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

namespace CaféPatronal.TELAS.CRUD.Fornec
{
    public partial class AlterarFornecedor : Form
    {
        Validação v = new Validação();
        public AlterarFornecedor()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CadastrarFornecedor tela = new CadastrarFornecedor();
            tela.Show();
            this.Hide();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.letras(e);
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.numeros(e);
        }
    }
}
