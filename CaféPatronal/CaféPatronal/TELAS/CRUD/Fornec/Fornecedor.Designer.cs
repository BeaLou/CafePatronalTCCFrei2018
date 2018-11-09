namespace CaféPatronal.TELAS.Cadastro_e_Consulta
{
    partial class CadastrarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarFornecedor));
            this.lblCep = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.mktCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeFornec = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mktTelefoneFixo = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneFixo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSalvarFornecedores = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvConsultarFornecedor = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConsultarFornece = new System.Windows.Forms.Button();
            this.txtconsultar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.BackColor = System.Drawing.Color.Transparent;
            this.lblCep.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCep.Location = new System.Drawing.Point(79, 42);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(44, 28);
            this.lblCep.TabIndex = 46;
            this.lblCep.Text = "CEP:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(129, 107);
            this.txtComplemento.MaxLength = 20;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(275, 32);
            this.txtComplemento.TabIndex = 6;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.Black;
            this.lblNumero.Location = new System.Drawing.Point(52, 178);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(71, 28);
            this.lblNumero.TabIndex = 45;
            this.lblNumero.Text = "Número";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.BackColor = System.Drawing.Color.Transparent;
            this.lblComplemento.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblComplemento.Location = new System.Drawing.Point(6, 109);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(117, 28);
            this.lblComplemento.TabIndex = 44;
            this.lblComplemento.Text = "Complemento:";
            // 
            // mktCnpj
            // 
            this.mktCnpj.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktCnpj.Location = new System.Drawing.Point(127, 107);
            this.mktCnpj.Mask = "00.000.000/0000-00";
            this.mktCnpj.Name = "mktCnpj";
            this.mktCnpj.Size = new System.Drawing.Size(275, 32);
            this.mktCnpj.TabIndex = 2;
            this.mktCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mktCpf_KeyPress);
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.BackColor = System.Drawing.Color.Transparent;
            this.lblCnpj.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCnpj.Location = new System.Drawing.Point(66, 109);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(55, 28);
            this.lblCnpj.TabIndex = 48;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(63, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 28);
            this.lblNome.TabIndex = 50;
            this.lblNome.Text = "Nome:";
            // 
            // txtNomeFornec
            // 
            this.txtNomeFornec.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFornec.Location = new System.Drawing.Point(127, 39);
            this.txtNomeFornec.MaxLength = 20;
            this.txtNomeFornec.Name = "txtNomeFornec";
            this.txtNomeFornec.Size = new System.Drawing.Size(275, 32);
            this.txtNomeFornec.TabIndex = 1;
            this.txtNomeFornec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(127, 174);
            this.txtemail.MaxLength = 50;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(275, 32);
            this.txtemail.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(66, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 28);
            this.label1.TabIndex = 52;
            this.label1.Text = "Email:";
            // 
            // mktTelefoneFixo
            // 
            this.mktTelefoneFixo.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktTelefoneFixo.Location = new System.Drawing.Point(127, 250);
            this.mktTelefoneFixo.Mask = "(00)0000-0000";
            this.mktTelefoneFixo.Name = "mktTelefoneFixo";
            this.mktTelefoneFixo.Size = new System.Drawing.Size(275, 32);
            this.mktTelefoneFixo.TabIndex = 4;
            this.mktTelefoneFixo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mktTelefoneFixo_KeyPress);
            // 
            // lblTelefoneFixo
            // 
            this.lblTelefoneFixo.AutoSize = true;
            this.lblTelefoneFixo.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefoneFixo.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneFixo.ForeColor = System.Drawing.Color.Black;
            this.lblTelefoneFixo.Location = new System.Drawing.Point(12, 252);
            this.lblTelefoneFixo.Name = "lblTelefoneFixo";
            this.lblTelefoneFixo.Size = new System.Drawing.Size(109, 28);
            this.lblTelefoneFixo.TabIndex = 54;
            this.lblTelefoneFixo.Text = "Telefone Fixo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 32);
            this.label2.TabIndex = 55;
            this.label2.Text = "CADASTRO DE FORNECEDOR\r\n";
            // 
            // mtbCep
            // 
            this.mtbCep.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCep.Location = new System.Drawing.Point(129, 40);
            this.mtbCep.Mask = "0:0000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(275, 32);
            this.mtbCep.TabIndex = 5;
            this.mtbCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCep_KeyPress);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::CaféPatronal.Properties.Resources.icon3;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(992, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(59, 57);
            this.btnVoltar.TabIndex = 58;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(49, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1065, 462);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Linen;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.btnSalvarFornecedores);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnVoltar);
            this.tabPage1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1057, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            // 
            // btnSalvarFornecedores
            // 
            this.btnSalvarFornecedores.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvarFornecedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarFornecedores.FlatAppearance.BorderSize = 0;
            this.btnSalvarFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarFornecedores.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarFornecedores.Image")));
            this.btnSalvarFornecedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarFornecedores.Location = new System.Drawing.Point(923, 380);
            this.btnSalvarFornecedores.Name = "btnSalvarFornecedores";
            this.btnSalvarFornecedores.Size = new System.Drawing.Size(126, 36);
            this.btnSalvarFornecedores.TabIndex = 8;
            this.btnSalvarFornecedores.Text = "Salvar";
            this.btnSalvarFornecedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarFornecedores.UseVisualStyleBackColor = false;
            this.btnSalvarFornecedores.Click += new System.EventHandler(this.btnSalvarFornecedores_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.mtbCep);
            this.groupBox2.Controls.Add(this.lblCep);
            this.groupBox2.Controls.Add(this.txtComplemento);
            this.groupBox2.Controls.Add(this.lblComplemento);
            this.groupBox2.Controls.Add(this.lblNumero);
            this.groupBox2.Location = new System.Drawing.Point(483, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 229);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(129, 176);
            this.txtNumero.MaxLength = 20;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(275, 32);
            this.txtNumero.TabIndex = 7;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCep_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomeFornec);
            this.groupBox1.Controls.Add(this.mktCnpj);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.lblCnpj);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.lblTelefoneFixo);
            this.groupBox1.Controls.Add(this.mktTelefoneFixo);
            this.groupBox1.Location = new System.Drawing.Point(25, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 303);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Linen;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.dgvConsultarFornecedor);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnConsultarFornece);
            this.tabPage2.Controls.Add(this.txtconsultar);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1057, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta/Apagar/Alterar";
            // 
            // dgvConsultarFornecedor
            // 
            this.dgvConsultarFornecedor.AllowUserToAddRows = false;
            this.dgvConsultarFornecedor.AllowUserToDeleteRows = false;
            this.dgvConsultarFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvConsultarFornecedor.Location = new System.Drawing.Point(66, 84);
            this.dgvConsultarFornecedor.Name = "dgvConsultarFornecedor";
            this.dgvConsultarFornecedor.ReadOnly = true;
            this.dgvConsultarFornecedor.Size = new System.Drawing.Size(905, 332);
            this.dgvConsultarFornecedor.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(750, 39);
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
            this.button1.Location = new System.Drawing.Point(641, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apagar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConsultarFornece
            // 
            this.btnConsultarFornece.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarFornece.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarFornece.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarFornece.Image")));
            this.btnConsultarFornece.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarFornece.Location = new System.Drawing.Point(528, 39);
            this.btnConsultarFornece.Name = "btnConsultarFornece";
            this.btnConsultarFornece.Size = new System.Drawing.Size(107, 38);
            this.btnConsultarFornece.TabIndex = 2;
            this.btnConsultarFornece.Text = "Consultar";
            this.btnConsultarFornece.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarFornece.UseVisualStyleBackColor = true;
            this.btnConsultarFornece.Click += new System.EventHandler(this.btnConsultarFornece_Click);
            // 
            // txtconsultar
            // 
            this.txtconsultar.BackColor = System.Drawing.Color.Ivory;
            this.txtconsultar.Location = new System.Drawing.Point(66, 42);
            this.txtconsultar.MaxLength = 50;
            this.txtconsultar.Name = "txtconsultar";
            this.txtconsultar.Size = new System.Drawing.Size(456, 32);
            this.txtconsultar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CaféPatronal.Properties.Resources.icon3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(990, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 57);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "FORNECEDOR";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "nm_nome";
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "ds_cnpj";
            this.Column2.HeaderText = "Cnpj";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "ds_telefone";
            this.Column3.HeaderText = "Telefone";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "ds_cep";
            this.Column4.HeaderText = "CEP";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "ds_complemento";
            this.Column5.HeaderText = "Complemento";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "ds_numerofornecedor";
            this.Column6.HeaderText = "Número";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "ds_email";
            this.Column7.HeaderText = "Email";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // CadastrarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1163, 498);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarFornecedor";
            this.Load += new System.EventHandler(this.CadastrarFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.MaskedTextBox mktCnpj;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNomeFornec;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mktTelefoneFixo;
        private System.Windows.Forms.Label lblTelefoneFixo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtconsultar;
        private System.Windows.Forms.Button btnConsultarFornece;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalvarFornecedores;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvConsultarFornecedor;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}