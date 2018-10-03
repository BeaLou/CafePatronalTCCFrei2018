using CaféPatronal.Programacao.Cliente;
using CaféPatronal.Programacao.Funcionario;
using CaféPatronal.TELAS.CRUD.Ped;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaféPatronal.TELAS.Cadastro_e_Consulta
{
    public partial class CadastrarPedido : Form
    {

        public CadastrarPedido()
        {
            InitializeComponent();
            CarregarCombos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlterarPedido tela = new AlterarPedido();
            tela.Show();
            this.Hide();
        }
        void CarregarCombos()
        {
            FuncionarioBusiness bus = new FuncionarioBusiness();
            List<FuncionarioDTO> lista = bus.Listar();
            cbFuncionarios.ValueMember = nameof(FuncionarioDTO.id_funcionario);
            cbFuncionarios.DisplayMember = nameof(FuncionarioDTO.nm_nome);
            cbFuncionarios.DataSource = lista;

            ClienteBusiness buss = new ClienteBusiness();
            List<ClienteDTO> listas = buss.Listar();
            cbClientes.ValueMember = nameof(ClienteDTO.id_cliente);
            cbClientes.DisplayMember = nameof(ClienteDTO.nm_nome);
            cbClientes.DataSource = listas;

        }
    }
}
