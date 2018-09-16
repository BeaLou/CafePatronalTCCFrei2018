namespace CaféPatronal.TELAS.Cadastro_e_Consulta
{
    partial class CadastrarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarProduto));
            this.lblNome = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataValidade = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCadastroProduto = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtConsultaProdutos = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblconsultaproduto = new System.Windows.Forms.Label();
            this.dgvconsultaproduto = new System.Windows.Forms.DataGridView();
            this.btnConsultarFornece = new System.Windows.Forms.Button();
            this.BtnSalvarProdutos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultaproduto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(100, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 28);
            this.lblNome.TabIndex = 30;
            this.lblNome.Text = "Nome:";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(164, 128);
            this.dtpDataNascimento.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpDataNascimento.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(535, 32);
            this.dtpDataNascimento.TabIndex = 3;
            this.dtpDataNascimento.Value = new System.DateTime(1910, 12, 31, 0, 0, 0, 0);
            // 
            // lblDataValidade
            // 
            this.lblDataValidade.AutoSize = true;
            this.lblDataValidade.BackColor = System.Drawing.Color.Transparent;
            this.lblDataValidade.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataValidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDataValidade.Location = new System.Drawing.Point(20, 132);
            this.lblDataValidade.Name = "lblDataValidade";
            this.lblDataValidade.Size = new System.Drawing.Size(138, 28);
            this.lblDataValidade.TabIndex = 3;
            this.lblDataValidade.Text = "Data de Validade:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(164, 82);
            this.txtSobrenome.MaxLength = 20;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(535, 32);
            this.txtSobrenome.TabIndex = 2;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidade.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(56, 74);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(98, 28);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 33);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(535, 32);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblCadastroProduto
            // 
            this.lblCadastroProduto.AutoSize = true;
            this.lblCadastroProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroProduto.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCadastroProduto.Location = new System.Drawing.Point(6, 6);
            this.lblCadastroProduto.Name = "lblCadastroProduto";
            this.lblCadastroProduto.Size = new System.Drawing.Size(196, 28);
            this.lblCadastroProduto.TabIndex = 31;
            this.lblCadastroProduto.Text = "CADASTRO DE PRODUTOS";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::CaféPatronal.Properties.Resources.icon3;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(994, 6);
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
            this.tabControl1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(49, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1064, 448);
            this.tabControl1.TabIndex = 60;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnSalvarProdutos);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lblCadastroProduto);
            this.tabPage1.Controls.Add(this.btnVoltar);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1056, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblDataValidade);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtSobrenome);
            this.groupBox1.Controls.Add(this.dtpDataNascimento);
            this.groupBox1.Controls.Add(this.lblQuantidade);
            this.groupBox1.Location = new System.Drawing.Point(168, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 183);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.txtConsultaProdutos);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.lblconsultaproduto);
            this.tabPage2.Controls.Add(this.dgvconsultaproduto);
            this.tabPage2.Controls.Add(this.btnConsultarFornece);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1056, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtConsultaProdutos
            // 
            this.txtConsultaProdutos.BackColor = System.Drawing.Color.Ivory;
            this.txtConsultaProdutos.Location = new System.Drawing.Point(58, 42);
            this.txtConsultaProdutos.MaxLength = 50;
            this.txtConsultaProdutos.Name = "txtConsultaProdutos";
            this.txtConsultaProdutos.Size = new System.Drawing.Size(456, 32);
            this.txtConsultaProdutos.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::CaféPatronal.Properties.Resources.icon3;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(989, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 57);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CaféPatronal.Properties.Resources.icon3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1079, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 10);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblconsultaproduto
            // 
            this.lblconsultaproduto.AutoSize = true;
            this.lblconsultaproduto.BackColor = System.Drawing.Color.Transparent;
            this.lblconsultaproduto.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconsultaproduto.Location = new System.Drawing.Point(2, 3);
            this.lblconsultaproduto.Name = "lblconsultaproduto";
            this.lblconsultaproduto.Size = new System.Drawing.Size(213, 34);
            this.lblconsultaproduto.TabIndex = 12;
            this.lblconsultaproduto.Text = "CONSULTA DE PRODUTOS";
            // 
            // dgvconsultaproduto
            // 
            this.dgvconsultaproduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsultaproduto.Location = new System.Drawing.Point(58, 80);
            this.dgvconsultaproduto.Name = "dgvconsultaproduto";
            this.dgvconsultaproduto.Size = new System.Drawing.Size(910, 308);
            this.dgvconsultaproduto.TabIndex = 11;
            // 
            // btnConsultarFornece
            // 
            this.btnConsultarFornece.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarFornece.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarFornece.Image")));
            this.btnConsultarFornece.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarFornece.Location = new System.Drawing.Point(537, 42);
            this.btnConsultarFornece.Name = "btnConsultarFornece";
            this.btnConsultarFornece.Size = new System.Drawing.Size(107, 32);
            this.btnConsultarFornece.TabIndex = 10;
            this.btnConsultarFornece.Text = "Consultar";
            this.btnConsultarFornece.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarFornece.UseVisualStyleBackColor = true;
            // 
            // BtnSalvarProdutos
            // 
            this.BtnSalvarProdutos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSalvarProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvarProdutos.FlatAppearance.BorderSize = 0;
            this.BtnSalvarProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalvarProdutos.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvarProdutos.Image")));
            this.BtnSalvarProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvarProdutos.Location = new System.Drawing.Point(924, 368);
            this.BtnSalvarProdutos.Name = "BtnSalvarProdutos";
            this.BtnSalvarProdutos.Size = new System.Drawing.Size(126, 36);
            this.BtnSalvarProdutos.TabIndex = 68;
            this.BtnSalvarProdutos.Text = "Salvar";
            this.BtnSalvarProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvarProdutos.UseVisualStyleBackColor = false;
            // 
            // CadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1163, 498);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarProduto";
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultaproduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblDataValidade;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCadastroProduto;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnConsultarFornece;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblconsultaproduto;
        private System.Windows.Forms.DataGridView dgvconsultaproduto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtConsultaProdutos;
        private System.Windows.Forms.Button BtnSalvarProdutos;
    }
}