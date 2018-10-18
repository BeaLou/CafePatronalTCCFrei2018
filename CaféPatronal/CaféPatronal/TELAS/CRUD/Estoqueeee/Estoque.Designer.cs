namespace CaféPatronal.TELAS
{
    partial class Consulta_de_Estoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_de_Estoque));
            this.dtpCompra = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.dtpValidade = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSalvarEstoque = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCadastroCliente = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvconsultaestoq = new System.Windows.Forms.DataGridView();
            this.lblconsultadclientre = new System.Windows.Forms.Label();
            this.btnConsultarestoque = new System.Windows.Forms.Button();
            this.txtConsultarEstoque = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultaestoq)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpCompra
            // 
            this.dtpCompra.Location = new System.Drawing.Point(186, 179);
            this.dtpCompra.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpCompra.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtpCompra.Name = "dtpCompra";
            this.dtpCompra.Size = new System.Drawing.Size(590, 31);
            this.dtpCompra.TabIndex = 3;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.BackColor = System.Drawing.Color.Transparent;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.ForeColor = System.Drawing.Color.Black;
            this.lblDataNascimento.Location = new System.Drawing.Point(39, 183);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(194, 29);
            this.lblDataNascimento.TabIndex = 26;
            this.lblDataNascimento.Text = "Data de Compra:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(186, 114);
            this.txtQuantidade.MaxLength = 20;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(590, 31);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.BackColor = System.Drawing.Color.Transparent;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(36, 114);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(144, 29);
            this.lblSobrenome.TabIndex = 25;
            this.lblSobrenome.Text = "Quantidade:";
            // 
            // dtpValidade
            // 
            this.dtpValidade.Location = new System.Drawing.Point(186, 259);
            this.dtpValidade.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpValidade.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(590, 31);
            this.dtpValidade.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "Data de Validade:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(186, 49);
            this.txtValor.MaxLength = 20;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(590, 31);
            this.txtValor.TabIndex = 1;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 29);
            this.label2.TabIndex = 29;
            this.label2.Text = "Valor da Compra:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::CaféPatronal.Properties.Resources.icon3;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(1015, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(59, 57);
            this.btnVoltar.TabIndex = 33;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(44, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1088, 507);
            this.tabControl1.TabIndex = 61;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSalvarEstoque);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnVoltar);
            this.tabPage1.Controls.Add(this.lblCadastroCliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1080, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSalvarEstoque
            // 
            this.btnSalvarEstoque.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvarEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarEstoque.FlatAppearance.BorderSize = 0;
            this.btnSalvarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarEstoque.Image")));
            this.btnSalvarEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarEstoque.Location = new System.Drawing.Point(948, 427);
            this.btnSalvarEstoque.Name = "btnSalvarEstoque";
            this.btnSalvarEstoque.Size = new System.Drawing.Size(126, 36);
            this.btnSalvarEstoque.TabIndex = 68;
            this.btnSalvarEstoque.Text = "Salvar";
            this.btnSalvarEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarEstoque.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtValor);
            this.groupBox2.Controls.Add(this.lblSobrenome);
            this.groupBox2.Controls.Add(this.dtpValidade);
            this.groupBox2.Controls.Add(this.txtQuantidade);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblDataNascimento);
            this.groupBox2.Controls.Add(this.dtpCompra);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(141, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(782, 322);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            // 
            // lblCadastroCliente
            // 
            this.lblCadastroCliente.AutoSize = true;
            this.lblCadastroCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroCliente.Location = new System.Drawing.Point(6, 3);
            this.lblCadastroCliente.Name = "lblCadastroCliente";
            this.lblCadastroCliente.Size = new System.Drawing.Size(374, 33);
            this.lblCadastroCliente.TabIndex = 4;
            this.lblCadastroCliente.Text = "CADASTRO DE ESTOQUE\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.dgvconsultaestoq);
            this.tabPage2.Controls.Add(this.lblconsultadclientre);
            this.tabPage2.Controls.Add(this.btnConsultarestoque);
            this.tabPage2.Controls.Add(this.txtConsultarEstoque);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1080, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta/Apagar/Alterar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(747, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "Alterar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(638, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Apagar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CaféPatronal.Properties.Resources.icon3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(1013, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 57);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dgvconsultaestoq
            // 
            this.dgvconsultaestoq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsultaestoq.Location = new System.Drawing.Point(63, 117);
            this.dgvconsultaestoq.Name = "dgvconsultaestoq";
            this.dgvconsultaestoq.Size = new System.Drawing.Size(910, 322);
            this.dgvconsultaestoq.TabIndex = 13;
            // 
            // lblconsultadclientre
            // 
            this.lblconsultadclientre.AutoSize = true;
            this.lblconsultadclientre.BackColor = System.Drawing.Color.Transparent;
            this.lblconsultadclientre.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconsultadclientre.Location = new System.Drawing.Point(2, 8);
            this.lblconsultadclientre.Name = "lblconsultadclientre";
            this.lblconsultadclientre.Size = new System.Drawing.Size(157, 33);
            this.lblconsultadclientre.TabIndex = 12;
            this.lblconsultadclientre.Text = "ESTOQUE\r\n";
            // 
            // btnConsultarestoque
            // 
            this.btnConsultarestoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarestoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarestoque.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarestoque.Image")));
            this.btnConsultarestoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarestoque.Location = new System.Drawing.Point(525, 79);
            this.btnConsultarestoque.Name = "btnConsultarestoque";
            this.btnConsultarestoque.Size = new System.Drawing.Size(107, 32);
            this.btnConsultarestoque.TabIndex = 10;
            this.btnConsultarestoque.Text = "Consultar";
            this.btnConsultarestoque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarestoque.UseVisualStyleBackColor = true;
            // 
            // txtConsultarEstoque
            // 
            this.txtConsultarEstoque.BackColor = System.Drawing.Color.Ivory;
            this.txtConsultarEstoque.Location = new System.Drawing.Point(63, 80);
            this.txtConsultarEstoque.MaxLength = 50;
            this.txtConsultarEstoque.Name = "txtConsultarEstoque";
            this.txtConsultarEstoque.Size = new System.Drawing.Size(456, 31);
            this.txtConsultarEstoque.TabIndex = 9;
            // 
            // Consulta_de_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1198, 537);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consulta_de_Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta_de_Estoque";
            this.Load += new System.EventHandler(this.Consulta_de_Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultaestoq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpCompra;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.DateTimePicker dtpValidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCadastroCliente;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblconsultadclientre;
        private System.Windows.Forms.Button btnConsultarestoque;
        private System.Windows.Forms.TextBox txtConsultarEstoque;
        private System.Windows.Forms.DataGridView dgvconsultaestoq;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalvarEstoque;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}