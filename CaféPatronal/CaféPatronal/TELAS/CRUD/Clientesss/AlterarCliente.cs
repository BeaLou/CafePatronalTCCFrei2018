using CaféPatronal.Programacao;
using CaféPatronal.Programacao.Cliente;
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
        ClienteDTO cliente;
        public AlterarCliente()
        {
            InitializeComponent();

        }
        public void LoadScreen(ClienteDTO cliente)
        {
            this.cliente = cliente;

            txtnome.Text = cliente.nm_nome;
            txtsobrenome.Text = cliente.nm_sobrenome;
            txtcpf.Text = cliente.ds_cpf;
            dtpnascimento.Value = cliente.dt_datanascimento;
            txtemail.Text = cliente.ds_email;


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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.nm_nome = txtnome.Text;
                cliente.nm_sobrenome = txtsobrenome.Text;
                cliente.ds_cpf = txtcpf.Text;
                cliente.dt_datanascimento = dtpnascimento.Value;
                cliente.ds_email = txtemail.Text;

                ClienteBusiness business = new ClienteBusiness();
                business.Alterar(cliente);
                MessageBox.Show("Cliente alterado com sucesso");

                Cadastro_de_Clientes tela = new Cadastro_de_Clientes();
                tela.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }
        }

        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.numeros(e);
        }
    }
}
