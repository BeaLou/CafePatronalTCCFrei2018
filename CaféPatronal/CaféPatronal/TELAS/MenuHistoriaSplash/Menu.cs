
using CaféPatronal.TELAS;
using System;
using System.Windows.Forms;

namespace CaféPatronal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        }
    }
}
