using CaféPatronal.Programacao;
using CaféPatronal.Programacao.Cliente;
using CaféPatronal.TELAS.CRUD.Clientesss;
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
    public partial class Cadastro_de_Clientes : Form
    {
        Validação V = new Validação();
        public Cadastro_de_Clientes()
        {
            InitializeComponent();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.letras(e);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();
        }

        private void btnSalvarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDTO dto = new ClienteDTO();
                dto.nm_nome = txtNome.Text;
                dto.nm_sobrenome = txtSobrenome.Text;
                dto.ds_cpf = mtbCpf.Text;
                dto.dt_datanascimento = dtpDataNascimento.Value;
                dto.ds_email = txtEmail.Text;

                ClienteBusiness business = new ClienteBusiness();
                business.Salvar(dto);

                MessageBox.Show("Cliente salvo com sucesso.");


            }
            catch(Exception ex)
            {
                MessageBox.Show("Occoreu um erro " + ex.Message);
            }

        }

        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            ClienteBusiness business = new ClienteBusiness();
            List<ClienteDTO> a = business.Consultar(txtConsultarClientes.Text);
            dgvConsultarCliente.AutoGenerateColumns = false;
            dgvConsultarCliente.DataSource = a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDTO cliente = dgvConsultarCliente.CurrentRow.DataBoundItem as ClienteDTO;

                AlterarCliente tela = new AlterarCliente();
                tela.LoadScreen(cliente);
                tela.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDTO cliente = dgvConsultarCliente.CurrentRow.DataBoundItem as ClienteDTO;
                DialogResult r = MessageBox.Show("Deseja excluir esse cliente?", "Café Patronal",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    ClienteBusiness business = new ClienteBusiness();
                    business.Remover(cliente.id_cliente);

                    List<ClienteDTO> a = business.Consultar(txtConsultarClientes.Text);
                    dgvConsultarCliente.AutoGenerateColumns = false;
                    dgvConsultarCliente.DataSource = a;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
            
        }

        private void mtbCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.numeros(e);
        }
    }
}
