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
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {
            InitializeComponent();
            Task.Factory.StartNew(() =>
            {
                // Espera 2 segundos para iniciar o sistema
                System.Threading.Thread.Sleep(6000);

                Invoke(new Action(() =>
                {
                    // Abre a tela Inicial
                    Login frm = new Login();
                    frm.Show();
                    Hide();
                }));
            });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
