namespace CaféPatronal.TELAS
{
    partial class Cadastro_de_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_de_Clientes));
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.lblCadastroCliente = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.mktCpf = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblNome = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSalvarClientes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblconsultadclientre = new System.Windows.Forms.Label();
            this.dgvConsultarCliente = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datanascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultarClientes = new System.Windows.Forms.Button();
            this.txtConsultarClientes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::CaféPatronal.Properties.Resources.icon3;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(1011, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(59, 57);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblCadastroCliente
            // 
            this.lblCadastroCliente.AutoSize = true;
            this.lblCadastroCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroCliente.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroCliente.Location = new System.Drawing.Point(6, 3);
            this.lblCadastroCliente.Name = "lblCadastroCliente";
            this.lblCadastroCliente.Size = new System.Drawing.Size(190, 34);
            this.lblCadastroCliente.TabIndex = 4;
            this.lblCadastroCliente.Text = "CADASTRO DE CLIENTE";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(140, 31);
            this.txtNome.MaxLength = 20;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(456, 32);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(140, 93);
            this.txtSobrenome.MaxLength = 20;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(456, 32);
            this.txtSobrenome.TabIndex = 2;
            this.txtSobrenome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.BackColor = System.Drawing.Color.Transparent;
            this.lblSobrenome.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(28, 93);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(102, 28);
            this.lblSobrenome.TabIndex = 6;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(144, 283);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(456, 32);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(35, 283);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 28);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.BackColor = System.Drawing.Color.Transparent;
            this.lblDataNascimento.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.ForeColor = System.Drawing.Color.Black;
            this.lblDataNascimento.Location = new System.Drawing.Point(27, 220);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(103, 56);
            this.lblDataNascimento.TabIndex = 10;
            this.lblDataNascimento.Text = "Data de \r\nNascimento:";
            // 
            // mktCpf
            // 
            this.mktCpf.AutoSize = true;
            this.mktCpf.BackColor = System.Drawing.Color.Transparent;
            this.mktCpf.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktCpf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mktCpf.Location = new System.Drawing.Point(35, 163);
            this.mktCpf.Name = "mktCpf";
            this.mktCpf.Size = new System.Drawing.Size(43, 28);
            this.mktCpf.TabIndex = 11;
            this.mktCpf.Text = "CPF:";
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(140, 159);
            this.mtbCpf.Mask = "000.000.000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(456, 32);
            this.mtbCpf.TabIndex = 3;
            this.mtbCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCpf_KeyPress);
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(140, 224);
            this.dtpDataNascimento.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.dtpDataNascimento.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(456, 32);
            this.dtpDataNascimento.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(35, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 28);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "Nome:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(41, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1084, 499);
            this.tabControl1.TabIndex = 60;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Linen;
            this.tabPage1.Controls.Add(this.btnSalvarClientes);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnVoltar);
            this.tabPage1.Controls.Add(this.lblCadastroCliente);
            this.tabPage1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1076, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            // 
            // btnSalvarClientes
            // 
            this.btnSalvarClientes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarClientes.FlatAppearance.BorderSize = 0;
            this.btnSalvarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarClientes.Image")));
            this.btnSalvarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarClientes.Location = new System.Drawing.Point(944, 419);
            this.btnSalvarClientes.Name = "btnSalvarClientes";
            this.btnSalvarClientes.Size = new System.Drawing.Size(126, 36);
            this.btnSalvarClientes.TabIndex = 68;
            this.btnSalvarClientes.Text = "Salvar";
            this.btnSalvarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarClientes.UseVisualStyleBackColor = false;
            this.btnSalvarClientes.Click += new System.EventHandler(this.btnSalvarClientes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.lblNome);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.dtpDataNascimento);
            this.groupBox2.Controls.Add(this.txtSobrenome);
            this.groupBox2.Controls.Add(this.lblDataNascimento);
            this.groupBox2.Controls.Add(this.mtbCpf);
            this.groupBox2.Controls.Add(this.lblSobrenome);
            this.groupBox2.Controls.Add(this.mktCpf);
            this.groupBox2.Location = new System.Drawing.Point(12, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 337);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Linen;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.lblconsultadclientre);
            this.tabPage2.Controls.Add(this.dgvConsultarCliente);
            this.tabPage2.Controls.Add(this.btnConsultarClientes);
            this.tabPage2.Controls.Add(this.txtConsultarClientes);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1076, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta/Apagar/Alterar";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(703, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 38);
            this.button2.TabIndex = 4;
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
            this.button1.Location = new System.Drawing.Point(594, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apagar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CaféPatronal.Properties.Resources.icon3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(1007, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 57);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblconsultadclientre
            // 
            this.lblconsultadclientre.AutoSize = true;
            this.lblconsultadclientre.BackColor = System.Drawing.Color.Transparent;
            this.lblconsultadclientre.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconsultadclientre.Location = new System.Drawing.Point(2, 8);
            this.lblconsultadclientre.Name = "lblconsultadclientre";
            this.lblconsultadclientre.Size = new System.Drawing.Size(75, 34);
            this.lblconsultadclientre.TabIndex = 12;
            this.lblconsultadclientre.Text = "CLIENTE";
            // 
            // dgvConsultarCliente
            // 
            this.dgvConsultarCliente.AllowUserToAddRows = false;
            this.dgvConsultarCliente.AllowUserToDeleteRows = false;
            this.dgvConsultarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Sobrenome,
            this.Datanascimento,
            this.Cpf,
            this.Email});
            this.dgvConsultarCliente.Location = new System.Drawing.Point(20, 98);
            this.dgvConsultarCliente.Name = "dgvConsultarCliente";
            this.dgvConsultarCliente.ReadOnly = true;
            this.dgvConsultarCliente.Size = new System.Drawing.Size(1016, 322);
            this.dgvConsultarCliente.TabIndex = 11;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "nm_nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Sobrenome
            // 
            this.Sobrenome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sobrenome.DataPropertyName = "nm_sobrenome";
            this.Sobrenome.HeaderText = "Sobrenome";
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.ReadOnly = true;
            // 
            // Datanascimento
            // 
            this.Datanascimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datanascimento.DataPropertyName = "dt_datanascimento";
            this.Datanascimento.HeaderText = "Data de nascimento";
            this.Datanascimento.Name = "Datanascimento";
            this.Datanascimento.ReadOnly = true;
            // 
            // Cpf
            // 
            this.Cpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cpf.DataPropertyName = "ds_cpf";
            this.Cpf.HeaderText = "Cpf";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "ds_email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // btnConsultarClientes
            // 
            this.btnConsultarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarClientes.Image")));
            this.btnConsultarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarClientes.Location = new System.Drawing.Point(481, 54);
            this.btnConsultarClientes.Name = "btnConsultarClientes";
            this.btnConsultarClientes.Size = new System.Drawing.Size(107, 38);
            this.btnConsultarClientes.TabIndex = 2;
            this.btnConsultarClientes.Text = "Consultar";
            this.btnConsultarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarClientes.UseVisualStyleBackColor = true;
            this.btnConsultarClientes.Click += new System.EventHandler(this.btnConsultarClientes_Click);
            // 
            // txtConsultarClientes
            // 
            this.txtConsultarClientes.BackColor = System.Drawing.Color.Ivory;
            this.txtConsultarClientes.Location = new System.Drawing.Point(20, 57);
            this.txtConsultarClientes.MaxLength = 50;
            this.txtConsultarClientes.Name = "txtConsultarClientes";
            this.txtConsultarClientes.Size = new System.Drawing.Size(456, 32);
            this.txtConsultarClientes.TabIndex = 1;
            // 
            // Cadastro_de_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1177, 526);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro_de_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro_de_Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.Label lblCadastroCliente;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label mktCpf;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnConsultarClientes;
        private System.Windows.Forms.TextBox txtConsultarClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblconsultadclientre;
        private System.Windows.Forms.DataGridView dgvConsultarCliente;
        private System.Windows.Forms.Button btnSalvarClientes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datanascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}