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
            this.mbtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.mbtRg = new System.Windows.Forms.MaskedTextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.mbtCarteiraTrabalho = new System.Windows.Forms.MaskedTextBox();
            this.lblCarteiraTrabalho = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.lblTelefoneFixo = new System.Windows.Forms.Label();
            this.lblTelefoneMóvel = new System.Windows.Forms.Label();
            this.mtbTelefoneFixo = new System.Windows.Forms.MaskedTextBox();
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefoneMovel = new System.Windows.Forms.MaskedTextBox();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSalvarFuncionário = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtsalariobruto = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCadastroCliente = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblconsultadclientre = new System.Windows.Forms.Label();
            this.dgvConsultarFuncionarios = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneMóvel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultarClientes = new System.Windows.Forms.Button();
            this.txtConsultarFuncionários = new System.Windows.Forms.TextBox();
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
            this.lblNome.Location = new System.Drawing.Point(68, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 28);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome:";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascimento.Location = new System.Drawing.Point(132, 130);
            this.dtpDataNascimento.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpDataNascimento.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(276, 32);
            this.dtpDataNascimento.TabIndex = 3;
            // 
            // mbtCpf
            // 
            this.mbtCpf.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtCpf.Location = new System.Drawing.Point(132, 257);
            this.mbtCpf.Mask = "000.000.000-00";
            this.mbtCpf.Name = "mbtCpf";
            this.mbtCpf.Size = new System.Drawing.Size(276, 32);
            this.mbtCpf.TabIndex = 5;
            this.mbtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mktCpf_KeyPress);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCpf.Location = new System.Drawing.Point(83, 259);
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
            this.lblDataNascimento.Location = new System.Drawing.Point(23, 118);
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
            this.lblDepartamento.Location = new System.Drawing.Point(5, 305);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(121, 28);
            this.lblDepartamento.TabIndex = 21;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(132, 78);
            this.txtSobrenome.MaxLength = 20;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(276, 32);
            this.txtSobrenome.TabIndex = 2;
            this.txtSobrenome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.BackColor = System.Drawing.Color.Transparent;
            this.lblSobrenome.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(24, 77);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(102, 28);
            this.lblSobrenome.TabIndex = 20;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(132, 31);
            this.txtNome.MaxLength = 20;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(276, 32);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(132, 351);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(276, 32);
            this.txtEmail.TabIndex = 7;
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.BackColor = System.Drawing.Color.Transparent;
            this.lblsenha.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.ForeColor = System.Drawing.Color.Black;
            this.lblsenha.Location = new System.Drawing.Point(86, 300);
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
            this.label1.Location = new System.Drawing.Point(71, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "Email:";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDepartamento.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(132, 303);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(276, 33);
            this.cboDepartamento.TabIndex = 6;
            this.cboDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // mbtRg
            // 
            this.mbtRg.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtRg.Location = new System.Drawing.Point(154, 217);
            this.mbtRg.Mask = "00.000.000-00";
            this.mbtRg.Name = "mbtRg";
            this.mbtRg.Size = new System.Drawing.Size(276, 32);
            this.mbtRg.TabIndex = 13;
            this.mbtRg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mktCpf_KeyPress);
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.BackColor = System.Drawing.Color.Transparent;
            this.lblRg.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.ForeColor = System.Drawing.Color.Black;
            this.lblRg.Location = new System.Drawing.Point(112, 216);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(36, 28);
            this.lblRg.TabIndex = 11;
            this.lblRg.Text = "RG:";
            this.lblRg.Click += new System.EventHandler(this.lblRg_Click);
            // 
            // mbtCarteiraTrabalho
            // 
            this.mbtCarteiraTrabalho.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbtCarteiraTrabalho.Location = new System.Drawing.Point(132, 196);
            this.mbtCarteiraTrabalho.Mask = "000.000.000-00";
            this.mbtCarteiraTrabalho.Name = "mbtCarteiraTrabalho";
            this.mbtCarteiraTrabalho.Size = new System.Drawing.Size(276, 32);
            this.mbtCarteiraTrabalho.TabIndex = 4;
            this.mbtCarteiraTrabalho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mktCpf_KeyPress);
            // 
            // lblCarteiraTrabalho
            // 
            this.lblCarteiraTrabalho.AutoSize = true;
            this.lblCarteiraTrabalho.BackColor = System.Drawing.Color.Transparent;
            this.lblCarteiraTrabalho.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarteiraTrabalho.ForeColor = System.Drawing.Color.Black;
            this.lblCarteiraTrabalho.Location = new System.Drawing.Point(29, 184);
            this.lblCarteiraTrabalho.Name = "lblCarteiraTrabalho";
            this.lblCarteiraTrabalho.Size = new System.Drawing.Size(97, 56);
            this.lblCarteiraTrabalho.TabIndex = 33;
            this.lblCarteiraTrabalho.Text = "Carteira de\r\n Trabalho:";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(154, 255);
            this.txtLogin.MaxLength = 20;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(276, 32);
            this.txtLogin.TabIndex = 14;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(94, 254);
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
            this.lblCep.Location = new System.Drawing.Point(104, 18);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(44, 28);
            this.lblCep.TabIndex = 40;
            this.lblCep.Text = "CEP:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(154, 54);
            this.txtComplemento.MaxLength = 20;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(276, 32);
            this.txtComplemento.TabIndex = 9;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNumero.Location = new System.Drawing.Point(77, 94);
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
            this.lblComplemento.Location = new System.Drawing.Point(31, 56);
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
            this.lblTelefoneFixo.Location = new System.Drawing.Point(39, 140);
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
            this.lblTelefoneMóvel.Location = new System.Drawing.Point(23, 181);
            this.lblTelefoneMóvel.Name = "lblTelefoneMóvel";
            this.lblTelefoneMóvel.Size = new System.Drawing.Size(125, 28);
            this.lblTelefoneMóvel.TabIndex = 42;
            this.lblTelefoneMóvel.Text = "Telefone Móvel:";
            // 
            // mtbTelefoneFixo
            // 
            this.mtbTelefoneFixo.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefoneFixo.Location = new System.Drawing.Point(154, 138);
            this.mtbTelefoneFixo.Mask = "(00)0000-0000";
            this.mtbTelefoneFixo.Name = "mtbTelefoneFixo";
            this.mtbTelefoneFixo.Size = new System.Drawing.Size(276, 32);
            this.mtbTelefoneFixo.TabIndex = 11;
            this.mtbTelefoneFixo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mktCpf_KeyPress);
            // 
            // mtbCep
            // 
            this.mtbCep.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCep.Location = new System.Drawing.Point(154, 16);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(276, 32);
            this.mtbCep.TabIndex = 8;
            this.mtbCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mktCpf_KeyPress);
            // 
            // mtbTelefoneMovel
            // 
            this.mtbTelefoneMovel.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefoneMovel.Location = new System.Drawing.Point(154, 179);
            this.mtbTelefoneMovel.Mask = "(00)00000-0000";
            this.mtbTelefoneMovel.Name = "mtbTelefoneMovel";
            this.mtbTelefoneMovel.Size = new System.Drawing.Size(276, 32);
            this.mtbTelefoneMovel.TabIndex = 12;
            this.mtbTelefoneMovel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            this.mtbTelefoneMovel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mktCpf_KeyPress);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::CaféPatronal.Properties.Resources.icon3;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(1036, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(58, 57);
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
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Linen;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.btnSalvarFuncionário);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnVoltar);
            this.tabPage1.Controls.Add(this.lblCadastroCliente);
            this.tabPage1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1102, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            // 
            // btnSalvarFuncionário
            // 
            this.btnSalvarFuncionário.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvarFuncionário.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarFuncionário.FlatAppearance.BorderSize = 0;
            this.btnSalvarFuncionário.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvarFuncionário.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFuncionário.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarFuncionário.Image")));
            this.btnSalvarFuncionário.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarFuncionário.Location = new System.Drawing.Point(974, 393);
            this.btnSalvarFuncionário.Name = "btnSalvarFuncionário";
            this.btnSalvarFuncionário.Size = new System.Drawing.Size(126, 36);
            this.btnSalvarFuncionário.TabIndex = 17;
            this.btnSalvarFuncionário.Text = "Salvar";
            this.btnSalvarFuncionário.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarFuncionário.UseVisualStyleBackColor = false;
            this.btnSalvarFuncionário.Click += new System.EventHandler(this.btnSalvarFuncionário_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtsalariobruto);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.lblNumero);
            this.groupBox1.Controls.Add(this.lblComplemento);
            this.groupBox1.Controls.Add(this.txtComplemento);
            this.groupBox1.Controls.Add(this.mtbCep);
            this.groupBox1.Controls.Add(this.txtLogin);
            this.groupBox1.Controls.Add(this.mtbTelefoneMovel);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.Controls.Add(this.lblRg);
            this.groupBox1.Controls.Add(this.lblCep);
            this.groupBox1.Controls.Add(this.mtbTelefoneFixo);
            this.groupBox1.Controls.Add(this.lblsenha);
            this.groupBox1.Controls.Add(this.mbtRg);
            this.groupBox1.Controls.Add(this.lblTelefoneMóvel);
            this.groupBox1.Controls.Add(this.lblTelefoneFixo);
            this.groupBox1.Location = new System.Drawing.Point(506, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 381);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(154, 301);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(276, 32);
            this.txtSenha.TabIndex = 15;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(37, 342);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 28);
            this.label18.TabIndex = 46;
            this.label18.Text = "Salário Bruto";
            // 
            // txtsalariobruto
            // 
            this.txtsalariobruto.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalariobruto.Location = new System.Drawing.Point(154, 343);
            this.txtsalariobruto.MaxLength = 45;
            this.txtsalariobruto.Name = "txtsalariobruto";
            this.txtsalariobruto.Size = new System.Drawing.Size(276, 32);
            this.txtsalariobruto.TabIndex = 16;
            this.txtsalariobruto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsalariobruto_KeyPress);
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(154, 92);
            this.txtNumero.MaxLength = 20;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(276, 32);
            this.txtNumero.TabIndex = 10;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mktCpf_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDepartamento);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.cboDepartamento);
            this.groupBox2.Controls.Add(this.lblCarteiraTrabalho);
            this.groupBox2.Controls.Add(this.mbtCarteiraTrabalho);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.lblSobrenome);
            this.groupBox2.Controls.Add(this.txtSobrenome);
            this.groupBox2.Controls.Add(this.lblDataNascimento);
            this.groupBox2.Controls.Add(this.lblCpf);
            this.groupBox2.Controls.Add(this.mbtCpf);
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
            this.lblCadastroCliente.Size = new System.Drawing.Size(233, 34);
            this.lblCadastroCliente.TabIndex = 4;
            this.lblCadastroCliente.Text = "CADASTRO DE FUNCIONÁRIO\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Linen;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.btnAlterar);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.lblconsultadclientre);
            this.tabPage2.Controls.Add(this.dgvConsultarFuncionarios);
            this.tabPage2.Controls.Add(this.btnConsultarClientes);
            this.tabPage2.Controls.Add(this.txtConsultarFuncionários);
            this.tabPage2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1102, 439);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta/Apagar/Alterar";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(744, 51);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(107, 38);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(635, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apagar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::CaféPatronal.Properties.Resources.icon3;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(1035, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 57);
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
            this.lblconsultadclientre.Size = new System.Drawing.Size(118, 34);
            this.lblconsultadclientre.TabIndex = 12;
            this.lblconsultadclientre.Text = "FUNCIONÁRIO";
            // 
            // dgvConsultarFuncionarios
            // 
            this.dgvConsultarFuncionarios.AllowUserToAddRows = false;
            this.dgvConsultarFuncionarios.AllowUserToDeleteRows = false;
            this.dgvConsultarFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Sobrenome,
            this.Departamento,
            this.Email,
            this.TelefoneMóvel});
            this.dgvConsultarFuncionarios.Location = new System.Drawing.Point(60, 101);
            this.dgvConsultarFuncionarios.Name = "dgvConsultarFuncionarios";
            this.dgvConsultarFuncionarios.ReadOnly = true;
            this.dgvConsultarFuncionarios.Size = new System.Drawing.Size(910, 322);
            this.dgvConsultarFuncionarios.TabIndex = 11;
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
            // Departamento
            // 
            this.Departamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Departamento.DataPropertyName = "ds_dpto";
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "ds_email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // TelefoneMóvel
            // 
            this.TelefoneMóvel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TelefoneMóvel.DataPropertyName = "ds_telefonemovel";
            this.TelefoneMóvel.HeaderText = "Telefone Móvel";
            this.TelefoneMóvel.Name = "TelefoneMóvel";
            this.TelefoneMóvel.ReadOnly = true;
            // 
            // btnConsultarClientes
            // 
            this.btnConsultarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarClientes.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarClientes.Image")));
            this.btnConsultarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarClientes.Location = new System.Drawing.Point(522, 51);
            this.btnConsultarClientes.Name = "btnConsultarClientes";
            this.btnConsultarClientes.Size = new System.Drawing.Size(107, 38);
            this.btnConsultarClientes.TabIndex = 2;
            this.btnConsultarClientes.Text = "Consultar";
            this.btnConsultarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarClientes.UseVisualStyleBackColor = true;
            this.btnConsultarClientes.Click += new System.EventHandler(this.btnConsultarClientes_Click);
            // 
            // txtConsultarFuncionários
            // 
            this.txtConsultarFuncionários.BackColor = System.Drawing.Color.Ivory;
            this.txtConsultarFuncionários.ForeColor = System.Drawing.SystemColors.Info;
            this.txtConsultarFuncionários.Location = new System.Drawing.Point(60, 54);
            this.txtConsultarFuncionários.MaxLength = 50;
            this.txtConsultarFuncionários.Name = "txtConsultarFuncionários";
            this.txtConsultarFuncionários.Size = new System.Drawing.Size(456, 32);
            this.txtConsultarFuncionários.TabIndex = 1;
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
        private System.Windows.Forms.MaskedTextBox mbtCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.MaskedTextBox mbtRg;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.MaskedTextBox mbtCarteiraTrabalho;
        private System.Windows.Forms.Label lblCarteiraTrabalho;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.Label lblTelefoneFixo;
        private System.Windows.Forms.Label lblTelefoneMóvel;
        private System.Windows.Forms.MaskedTextBox mtbTelefoneFixo;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.MaskedTextBox mtbTelefoneMovel;
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
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneMóvel;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtsalariobruto;
        private System.Windows.Forms.TextBox txtSenha;
    }
}