using CaféPatronal.Programacao.Funcionario;
using Nsf._2018.Modulo2.DB.Filosofia.Plugin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaféPatronal.TELAS.MenuHistoriaSplashSobre
{
    public partial class Esqueci : Form
    {
        public Esqueci()
        {
            InitializeComponent();
            CarregarCombinho();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Login tela = new Login();
            tela.Show();
            this.Hide();
        }
        Email email = new Email();
        void CarregarCombinho()
        {
            FuncionarioBusiness business = new FuncionarioBusiness();
            List<FuncionarioDTO> lista = business.Listar();

            comboBox1.ValueMember = nameof(FuncionarioDTO.id_funcionario);
            comboBox1.DisplayMember = nameof(FuncionarioDTO.nm_nome);
            comboBox1.DataSource = lista;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FuncionarioDTO dto = new FuncionarioDTO();
            FuncionarioDTO cata = comboBox1.SelectedItem as FuncionarioDTO;
            FuncionarioDTO form = comboBox1.SelectedItem as FuncionarioDTO;


            string nome = cata.nm_nome;
            string paraqm = txtAssunto.Text;
            string eemail = form.ds_email;
            string pega = cata.ds_senha;

            email.Para = paraqm;
            email.Assunto = "Recuperação de senha - Café Patronal/Parthenon";
            email.Mensagem = "Olá, " + nome + " foi solicitado uma recuperação de senha para sua conta no sistema " +
                " Café Patronal, sua senha" + " é " + pega + ", caso você não tenha solicitado uma recuperação, comunique a gerência. GRATO EQUIPE PARTHENON";
            if (eemail == paraqm)
            {
                email.Enviar();
                MessageBox.Show("E-mail enviado com sucesso", "Café Patronal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Esse e-mail não condiz com sua conta", "Café Patronal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
