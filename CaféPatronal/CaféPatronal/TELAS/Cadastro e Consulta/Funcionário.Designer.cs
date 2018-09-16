namespace CaféPatronal.TELAS.Cadastro_e_Consulta
{
    partial class CadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFuncionario));
            this.lblNome = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.mktCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.mktRg = new System.Windows.Forms.MaskedTextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.mktCarteiraTrabalho = new System.Windows.Forms.MaskedTextBox();
            this.lblCarteiraTrabalho = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblTelefoneFixo = new System.Windows.Forms.Label();
            this.lblTelefoneMóvel = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbCepFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCadastroCliente = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblconsultadclientre = new System.Windows.Forms.Label();
            this.dgvConsultarFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnConsultarClientes = new System.Windows.Forms.Button();
            this.txtConsultarFuncionários = new System.Windows.Forms.TextBox();
            this.btnSalvarFuncionário = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(31, 28);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 28);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome:";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(135, 149);
            this.dtpDataNascimento.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpDataNascimento.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(275, 32);
            this.dtpDataNascimento.TabIndex = 3;
            // 
            // mktCpf
            // 
            this.mktCpf.Location = new System.Drawing.Point(135, 250);
            this.mktCpf.Mask = "000.000.000-00";
            this.mktCpf.Name = "mktCpf";
            this.mktCpf.Size = new System.Drawing.Size(275, 32);
            this.mktCpf.TabIndex = 4;
            this.mktCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mktCpf_KeyPress);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCpf.Location = new System.Drawing.Point(31, 250);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(43, 28);
            this.lblCpf.TabIndex = 23;
            this.lblCpf.Text = "CPF:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.BackColor = System.Drawing.Color.Transparent;
            this.lblDataNascimento.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDataNascimento.Location = new System.Drawing.Point(16, 125);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(103, 56);
            this.lblDataNascimento.TabIndex = 22;
            this.lblDataNascimento.Text = "Data de\r\nNascimento:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartamento.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.ForeColor = System.Drawing.Color.Black;
            this.lblDepartamento.Location = new System.Drawing.Point(16, 298);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(121, 28);
            this.lblDepartamento.TabIndex = 21;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(135, 80);
            this.txtSobrenome.MaxLength = 20;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(275, 32);
            this.txtSobrenome.TabIndex = 2;
            this.txtSobrenome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.BackColor = System.Drawing.Color.Transparent;
            this.lblSobrenome.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(15, 80);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(102, 28);
            this.lblSobrenome.TabIndex = 20;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(135, 27);
            this.txtNome.MaxLength = 20;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(275, 32);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(158, 351);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(275, 32);
            this.txtSenha.TabIndex = 15;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 347);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(275, 32);
            this.textBox2.TabIndex = 8;
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.BackColor = System.Drawing.Color.Transparent;
            this.lblsenha.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.ForeColor = System.Drawing.Color.Black;
            this.lblsenha.Location = new System.Drawing.Point(35, 351);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(62, 28);
            this.lblsenha.TabIndex = 27;
            this.lblsenha.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Email:";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(135, 299);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(275, 33);
            this.cboDepartamento.TabIndex = 7;
            this.cboDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // mktRg
            // 
            this.mktRg.Location = new System.Drawing.Point(158, 275);
            this.mktRg.Mask = "00.000.000-00";
            this.mktRg.Name = "mktRg";
            this.mktRg.Size = new System.Drawing.Size(275, 32);
            this.mktRg.TabIndex = 5;
            this.mktRg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mktCpf_KeyPress);
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.BackColor = System.Drawing.Color.Transparent;
            this.lblRg.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.ForeColor = System.Drawing.Color.Black;
            this.lblRg.Location = new System.Drawing.Point(35, 275);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(36, 28);
            this.lblRg.TabIndex = 11;
            this.lblRg.Text = "RG:";
            this.lblRg.Click += new System.EventHandler(this.lblRg_Click);
            // 
            // mktCarteiraTrabalho
            // 
            this.mktCarteiraTrabalho.Location = new System.Drawing.Point(135, 198);
            this.mktCarteiraTrabalho.Mask = "000.000.000-00";
            this.mktCarteiraTrabalho.Name = "mktCarteiraTrabalho";
            this.mktCarteiraTrabalho.Size = new System.Drawing.Size(275, 32);
            this.mktCarteiraTrabalho.TabIndex = 6;
            this.mktCarteiraTrabalho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mktCpf_KeyPress);
            // 
            // lblCarteiraTrabalho
            // 
            this.lblCarteiraTrabalho.AutoSize = true;
            this.lblCarteiraTrabalho.BackColor = System.Drawing.Color.Transparent;
            this.lblCarteiraTrabalho.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarteiraTrabalho.ForeColor = System.Drawing.Color.Black;
            this.lblCarteiraTrabalho.Location = new System.Drawing.Point(15, 181);
            this.lblCarteiraTrabalho.Name = "lblCarteiraTrabalho";
            this.lblCarteiraTrabalho.Size = new System.Drawing.Size(97, 56);
            this.lblCarteiraTrabalho.TabIndex = 33;
            this.lblCarteiraTrabalho.Text = "Carteira de\r\n Trabalho:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(158, 313);
            this.txtLogin.MaxLength = 20;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(275, 32);
            this.txtLogin.TabIndex = 14;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(35, 313);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(54, 28);
            this.lblLogin.TabIndex = 34;
            this.lblLogin.Text = "Login:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.BackColor = System.Drawing.Color.Transparent;
            this.lblCep.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCep.Location = new System.Drawing.Point(35, 16);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(44, 28);
            this.lblCep.TabIndex = 40;
            this.lblCep.Text = "CEP:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(158, 115);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '*';
            this.txtNumero.Size = new System.Drawing.Size(275, 32);
            this.txtNumero.TabIndex = 11;
            this.txtNumero.UseSystemPasswordChar = true;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mktCpf_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(158, 66);
            this.textBox5.MaxLength = 20;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(275, 32);
            this.textBox5.TabIndex = 10;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNumero.Location = new System.Drawing.Point(25, 119);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(71, 28);
            this.lblNumero.TabIndex = 38;
            this.lblNumero.Text = "Número";
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.BackColor = System.Drawing.Color.Transparent;
            this.lblComplemento.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblComplemento.Location = new System.Drawing.Point(25, 66);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(117, 28);
            this.lblComplemento.TabIndex = 36;
            this.lblComplemento.Text = "Complemento:";
            // 
            // lblTelefoneFixo
            // 
            this.lblTelefoneFixo.AutoSize = true;
            this.lblTelefoneFixo.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefoneFixo.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneFixo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTelefoneFixo.Location = new System.Drawing.Point(17, 169);
            this.lblTelefoneFixo.Name = "lblTelefoneFixo";
            this.lblTelefoneFixo.Size = new System.Drawing.Size(109, 28);
            this.lblTelefoneFixo.TabIndex = 43;
            this.lblTelefoneFixo.Text = "Telefone Fixo:";
            // 
            // lblTelefoneMóvel
            // 
            this.lblTelefoneMóvel.AutoSize = true;
            this.lblTelefoneMóvel.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefoneMóvel.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneMóvel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTelefoneMóvel.Location = new System.Drawing.Point(17, 222);
            this.lblTelefoneMóvel.Name = "lblTelefoneMóvel";
            this.lblTelefoneMóvel.Size = new System.Drawing.Size(125, 28);
            this.lblTelefoneMóvel.TabIndex = 42;
            this.lblTelefoneMóvel.Text = "Telefone Móvel:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(158, 169);
            this.maskedTextBox1.Mask = "(00)0000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(275, 32);
            this.maskedTextBox1.TabIndex = 12;
            this.maskedTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mktCpf_KeyPress);
            // 
            // mtbCepFuncionario
            // 
            this.mtbCepFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbCepFuncionario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCepFuncionario.Location = new System.Drawing.Point(158, 23);
            this.mtbCepFuncionario.Mask = "00000-000";
            this.mtbCepFuncionario.Name = "mtbCepFuncionario";
            this.mtbCepFuncionario.Size = new System.Drawing.Size(275, 21);
            this.mtbCepFuncionario.TabIndex = 47;
            this.mtbCepFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mktCpf_KeyPress);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(158, 218);
            this.maskedTextBox2.Mask = "(00)00000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(275, 32);
            this.maskedTextBox2.TabIndex = 13;
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            this.maskedTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mktCpf_KeyPress);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::CaféPatronal.Properties.Resources.icon3;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(1037, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(59, 57);
            this.btnVoltar.TabIndex = 49;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(34, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1110, 477);
            this.tabControl1.TabIndex = 61;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSalvarFuncionário);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnVoltar);
            this.tabPage1.Controls.Add(this.lblCadastroCliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1102, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Controls.Add(this.lblComplemento);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.mtbCepFuncionario);
            this.groupBox1.Controls.Add(this.txtLogin);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.Controls.Add(this.lblRg);
            this.groupBox1.Controls.Add(this.lblCep);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.lblsenha);
            this.groupBox1.Controls.Add(this.mktRg);
            this.groupBox1.Controls.Add(this.lblTelefoneMóvel);
            this.groupBox1.Controls.Add(this.lblTelefoneFixo);
            this.groupBox1.Location = new System.Drawing.Point(506, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 391);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDepartamento);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.cboDepartamento);
            this.groupBox2.Controls.Add(this.lblCarteiraTrabalho);
            this.groupBox2.Controls.Add(this.mktCarteiraTrabalho);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.lblSobrenome);
            this.groupBox2.Controls.Add(this.txtSobrenome);
            this.groupBox2.Controls.Add(this.lblDataNascimento);
            this.groupBox2.Controls.Add(this.lblCpf);
            this.groupBox2.Controls.Add(this.mktCpf);
            this.groupBox2.Controls.Add(this.lblNome);
            this.groupBox2.Controls.Add(this.dtpDataNascimento);
            this.groupBox2.Location = new System.Drawing.Point(12, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 391);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            // 
            // lblCadastroCliente
            // 
            this.lblCadastroCliente.AutoSize = true;
            this.lblCadastroCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroCliente.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroCliente.Location = new System.Drawing.Point(6, 3);
            this.lblCadastroCliente.Name = "lblCadastroCliente";
            this.lblCadastroCliente.Size = new System.Drawing.Size(244, 34);
            this.lblCadastroCliente.TabIndex = 4;
            this.lblCadastroCliente.Text = "CADASTRO DE FUNCIONÁRIOS\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.lblconsultadclientre);
            this.tabPage2.Controls.Add(this.dgvConsultarFuncionarios);
            this.tabPage2.Controls.Add(this.btnConsultarClientes);
            this.tabPage2.Controls.Add(this.txtConsultarFuncionários);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1102, 439);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::CaféPatronal.Properties.Resources.icon3;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(1035, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 57);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblconsultadclientre
            // 
            this.lblconsultadclientre.AutoSize = true;
            this.lblconsultadclientre.BackColor = System.Drawing.Color.Transparent;
            this.lblconsultadclientre.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconsultadclientre.Location = new System.Drawing.Point(2, 8);
            this.lblconsultadclientre.Name = "lblconsultadclientre";
            this.lblconsultadclientre.Size = new System.Drawing.Size(227, 34);
            this.lblconsultadclientre.TabIndex = 12;
            this.lblconsultadclientre.Text = "CONSULTAR FUNCIONÁRIOS\r\n";
            // 
            // dgvConsultarFuncionarios
            // 
            this.dgvConsultarFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarFuncionarios.Location = new System.Drawing.Point(60, 101);
            this.dgvConsultarFuncionarios.Name = "dgvConsultarFuncionarios";
            this.dgvConsultarFuncionarios.Size = new System.Drawing.Size(910, 322);
            this.dgvConsultarFuncionarios.TabIndex = 11;
            // 
            // btnConsultarClientes
            // 
            this.btnConsultarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarClientes.Image")));
            this.btnConsultarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarClientes.Location = new System.Drawing.Point(520, 63);
            this.btnConsultarClientes.Name = "btnConsultarClientes";
            this.btnConsultarClientes.Size = new System.Drawing.Size(107, 32);
            this.btnConsultarClientes.TabIndex = 10;
            this.btnConsultarClientes.Text = "Consultar";
            this.btnConsultarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarClientes.UseVisualStyleBackColor = true;
            // 
            // txtConsultarFuncionários
            // 
            this.txtConsultarFuncionários.BackColor = System.Drawing.Color.Ivory;
            this.txtConsultarFuncionários.Location = new System.Drawing.Point(58, 64);
            this.txtConsultarFuncionários.MaxLength = 50;
            this.txtConsultarFuncionários.Name = "txtConsultarFuncionários";
            this.txtConsultarFuncionários.Size = new System.Drawing.Size(456, 32);
            this.txtConsultarFuncionários.TabIndex = 9;
            // 
            // btnSalvarFuncionário
            // 
            this.btnSalvarFuncionário.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvarFuncionário.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarFuncionário.FlatAppearance.BorderSize = 0;
            this.btnSalvarFuncionário.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarFuncionário.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarFuncionário.Image")));
            this.btnSalvarFuncionário.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarFuncionário.Location = new System.Drawing.Point(973, 393);
            this.btnSalvarFuncionário.Name = "btnSalvarFuncionário";
            this.btnSalvarFuncionário.Size = new System.Drawing.Size(126, 36);
            this.btnSalvarFuncionário.TabIndex = 68;
            this.btnSalvarFuncionário.Text = "Salvar";
            this.btnSalvarFuncionário.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarFuncionário.UseVisualStyleBackColor = false;
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 536);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.MaskedTextBox mktCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.MaskedTextBox mktRg;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.MaskedTextBox mktCarteiraTrabalho;
        private System.Windows.Forms.Label lblCarteiraTrabalho;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblTelefoneFixo;
        private System.Windows.Forms.Label lblTelefoneMóvel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox mtbCepFuncionario;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCadastroCliente;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblconsultadclientre;
        private System.Windows.Forms.DataGridView dgvConsultarFuncionarios;
        private System.Windows.Forms.Button btnConsultarClientes;
        private System.Windows.Forms.TextBox txtConsultarFuncionários;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalvarFuncionário;
    }
}