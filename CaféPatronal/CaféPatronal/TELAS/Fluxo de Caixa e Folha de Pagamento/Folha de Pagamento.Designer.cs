namespace CaféPatronal.TELAS.Fluxo_de_Caixa_e_Folha_de_Pagamento
{
    partial class Folha_de_Pagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Folha_de_Pagamento));
            this.lblCadastroFuncionario = new System.Windows.Forms.Label();
            this.txtValeAlimentação = new System.Windows.Forms.TextBox();
            this.lblAlimentacao = new System.Windows.Forms.Label();
            this.txtValeRefeição = new System.Windows.Forms.TextBox();
            this.lblRefeicao = new System.Windows.Forms.Label();
            this.lblInss = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblConveio = new System.Windows.Forms.Label();
            this.txtInss = new System.Windows.Forms.TextBox();
            this.txtValeTransporte = new System.Windows.Forms.TextBox();
            this.lblTransporte = new System.Windows.Forms.Label();
            this.txtTelefonnet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAgua = new System.Windows.Forms.TextBox();
            this.txtLuz = new System.Windows.Forms.TextBox();
            this.lblLuz = new System.Windows.Forms.Label();
            this.lblAgua = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadastroFuncionario
            // 
            this.lblCadastroFuncionario.AutoSize = true;
            this.lblCadastroFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastroFuncionario.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroFuncionario.Location = new System.Drawing.Point(426, 56);
            this.lblCadastroFuncionario.Name = "lblCadastroFuncionario";
            this.lblCadastroFuncionario.Size = new System.Drawing.Size(173, 28);
            this.lblCadastroFuncionario.TabIndex = 55;
            this.lblCadastroFuncionario.Text = "FOLHA DE PAGAMENTO";
            // 
            // txtValeAlimentação
            // 
            this.txtValeAlimentação.Location = new System.Drawing.Point(683, 181);
            this.txtValeAlimentação.MaxLength = 10;
            this.txtValeAlimentação.Name = "txtValeAlimentação";
            this.txtValeAlimentação.Size = new System.Drawing.Size(275, 20);
            this.txtValeAlimentação.TabIndex = 6;
            this.txtValeAlimentação.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInss_KeyPress);
            // 
            // lblAlimentacao
            // 
            this.lblAlimentacao.AutoSize = true;
            this.lblAlimentacao.BackColor = System.Drawing.Color.Transparent;
            this.lblAlimentacao.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlimentacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAlimentacao.Location = new System.Drawing.Point(520, 173);
            this.lblAlimentacao.Name = "lblAlimentacao";
            this.lblAlimentacao.Size = new System.Drawing.Size(142, 28);
            this.lblAlimentacao.TabIndex = 54;
            this.lblAlimentacao.Text = "Vale Alimentação:";
            // 
            // txtValeRefeição
            // 
            this.txtValeRefeição.Location = new System.Drawing.Point(683, 229);
            this.txtValeRefeição.MaxLength = 10;
            this.txtValeRefeição.Name = "txtValeRefeição";
            this.txtValeRefeição.Size = new System.Drawing.Size(275, 20);
            this.txtValeRefeição.TabIndex = 7;
            this.txtValeRefeição.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInss_KeyPress);
            // 
            // lblRefeicao
            // 
            this.lblRefeicao.AutoSize = true;
            this.lblRefeicao.BackColor = System.Drawing.Color.Transparent;
            this.lblRefeicao.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefeicao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRefeicao.Location = new System.Drawing.Point(533, 221);
            this.lblRefeicao.Name = "lblRefeicao";
            this.lblRefeicao.Size = new System.Drawing.Size(114, 28);
            this.lblRefeicao.TabIndex = 53;
            this.lblRefeicao.Text = "Vale Refeição:";
            // 
            // lblInss
            // 
            this.lblInss.AutoSize = true;
            this.lblInss.BackColor = System.Drawing.Color.Transparent;
            this.lblInss.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInss.Location = new System.Drawing.Point(141, 172);
            this.lblInss.Name = "lblInss";
            this.lblInss.Size = new System.Drawing.Size(50, 28);
            this.lblInss.TabIndex = 52;
            this.lblInss.Text = "INSS:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(210, 229);
            this.txtSobrenome.MaxLength = 20;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(275, 20);
            this.txtSobrenome.TabIndex = 2;
            this.txtSobrenome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInss_KeyPress);
            // 
            // lblConveio
            // 
            this.lblConveio.AutoSize = true;
            this.lblConveio.BackColor = System.Drawing.Color.Transparent;
            this.lblConveio.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConveio.Location = new System.Drawing.Point(102, 221);
            this.lblConveio.Name = "lblConveio";
            this.lblConveio.Size = new System.Drawing.Size(83, 28);
            this.lblConveio.TabIndex = 51;
            this.lblConveio.Text = "Convênio:";
            // 
            // txtInss
            // 
            this.txtInss.Location = new System.Drawing.Point(210, 180);
            this.txtInss.MaxLength = 20;
            this.txtInss.Name = "txtInss";
            this.txtInss.Size = new System.Drawing.Size(275, 20);
            this.txtInss.TabIndex = 1;
            this.txtInss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInss_KeyPress);
            // 
            // txtValeTransporte
            // 
            this.txtValeTransporte.Location = new System.Drawing.Point(683, 275);
            this.txtValeTransporte.MaxLength = 10;
            this.txtValeTransporte.Name = "txtValeTransporte";
            this.txtValeTransporte.Size = new System.Drawing.Size(275, 20);
            this.txtValeTransporte.TabIndex = 8;
            this.txtValeTransporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInss_KeyPress);
            // 
            // lblTransporte
            // 
            this.lblTransporte.AutoSize = true;
            this.lblTransporte.BackColor = System.Drawing.Color.Transparent;
            this.lblTransporte.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransporte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTransporte.Location = new System.Drawing.Point(520, 274);
            this.lblTransporte.Name = "lblTransporte";
            this.lblTransporte.Size = new System.Drawing.Size(134, 28);
            this.lblTransporte.TabIndex = 61;
            this.lblTransporte.Text = "Vale Transporte:";
            // 
            // txtTelefonnet
            // 
            this.txtTelefonnet.Location = new System.Drawing.Point(210, 398);
            this.txtTelefonnet.MaxLength = 10;
            this.txtTelefonnet.Name = "txtTelefonnet";
            this.txtTelefonnet.Size = new System.Drawing.Size(275, 20);
            this.txtTelefonnet.TabIndex = 5;
            this.txtTelefonnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInss_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(46, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 28);
            this.label2.TabIndex = 60;
            this.label2.Text = "Telefone/Internet:";
            // 
            // txtAgua
            // 
            this.txtAgua.Location = new System.Drawing.Point(210, 342);
            this.txtAgua.MaxLength = 20;
            this.txtAgua.Name = "txtAgua";
            this.txtAgua.Size = new System.Drawing.Size(275, 20);
            this.txtAgua.TabIndex = 4;
            this.txtAgua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInss_KeyPress);
            // 
            // txtLuz
            // 
            this.txtLuz.Location = new System.Drawing.Point(210, 293);
            this.txtLuz.MaxLength = 20;
            this.txtLuz.Name = "txtLuz";
            this.txtLuz.Size = new System.Drawing.Size(275, 20);
            this.txtLuz.TabIndex = 3;
            this.txtLuz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInss_KeyPress);
            // 
            // lblLuz
            // 
            this.lblLuz.AutoSize = true;
            this.lblLuz.BackColor = System.Drawing.Color.Transparent;
            this.lblLuz.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuz.Location = new System.Drawing.Point(145, 284);
            this.lblLuz.Name = "lblLuz";
            this.lblLuz.Size = new System.Drawing.Size(40, 28);
            this.lblLuz.TabIndex = 63;
            this.lblLuz.Text = "Luz:";
            // 
            // lblAgua
            // 
            this.lblAgua.AutoSize = true;
            this.lblAgua.BackColor = System.Drawing.Color.Transparent;
            this.lblAgua.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAgua.Location = new System.Drawing.Point(132, 334);
            this.lblAgua.Name = "lblAgua";
            this.lblAgua.Size = new System.Drawing.Size(53, 28);
            this.lblAgua.TabIndex = 62;
            this.lblAgua.Text = "Água:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::CaféPatronal.Properties.Resources.icon3;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(1108, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(59, 57);
            this.btnVoltar.TabIndex = 65;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = global::CaféPatronal.Properties.Resources.icon2;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Location = new System.Drawing.Point(1108, 98);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(59, 57);
            this.btnSalvar.TabIndex = 64;
            this.btnSalvar.TabStop = false;
            // 
            // Folha_de_Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CaféPatronal.Properties.Resources.cafe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 536);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblLuz);
            this.Controls.Add(this.lblAgua);
            this.Controls.Add(this.txtValeTransporte);
            this.Controls.Add(this.lblTransporte);
            this.Controls.Add(this.txtTelefonnet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAgua);
            this.Controls.Add(this.txtLuz);
            this.Controls.Add(this.lblCadastroFuncionario);
            this.Controls.Add(this.txtValeAlimentação);
            this.Controls.Add(this.lblAlimentacao);
            this.Controls.Add(this.txtValeRefeição);
            this.Controls.Add(this.lblRefeicao);
            this.Controls.Add(this.lblInss);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.lblConveio);
            this.Controls.Add(this.txtInss);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Folha_de_Pagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folha_de_Pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalvar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastroFuncionario;
        private System.Windows.Forms.TextBox txtValeAlimentação;
        private System.Windows.Forms.Label lblAlimentacao;
        private System.Windows.Forms.TextBox txtValeRefeição;
        private System.Windows.Forms.Label lblRefeicao;
        private System.Windows.Forms.Label lblInss;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lblConveio;
        private System.Windows.Forms.TextBox txtInss;
        private System.Windows.Forms.TextBox txtValeTransporte;
        private System.Windows.Forms.Label lblTransporte;
        private System.Windows.Forms.TextBox txtTelefonnet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAgua;
        private System.Windows.Forms.TextBox txtLuz;
        private System.Windows.Forms.Label lblLuz;
        private System.Windows.Forms.Label lblAgua;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.PictureBox btnSalvar;
    }
}