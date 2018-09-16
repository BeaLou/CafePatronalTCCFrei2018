namespace CaféPatronal.TELAS.Cadastro_e_Consulta
{
    partial class CadastrarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarPedido));
            this.lblEstoque = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValorFinal = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFuncionarios = new System.Windows.Forms.ComboBox();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnConsultarPedidos = new System.Windows.Forms.Button();
            this.txtConsultapedidos = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblconsultarpedidos = new System.Windows.Forms.Label();
            this.dgvConsultarPedidos = new System.Windows.Forms.DataGridView();
            this.BtnSalvarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.BackColor = System.Drawing.Color.Transparent;
            this.lblEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEstoque.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.ForeColor = System.Drawing.Color.Black;
            this.lblEstoque.Location = new System.Drawing.Point(3, 3);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(74, 28);
            this.lblEstoque.TabIndex = 34;
            this.lblEstoque.Text = "PEDIDOS";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(202, 179);
            this.txtValor.MaxLength = 50;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(590, 32);
            this.txtValor.TabIndex = 1;
            // 
            // lblValorFinal
            // 
            this.lblValorFinal.AutoSize = true;
            this.lblValorFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblValorFinal.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFinal.ForeColor = System.Drawing.Color.Black;
            this.lblValorFinal.Location = new System.Drawing.Point(40, 179);
            this.lblValorFinal.Name = "lblValorFinal";
            this.lblValorFinal.Size = new System.Drawing.Size(141, 28);
            this.lblValorFinal.TabIndex = 33;
            this.lblValorFinal.Text = "Valor da Compra:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::CaféPatronal.Properties.Resources.icon3;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(1041, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(59, 57);
            this.btnVoltar.TabIndex = 36;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(25, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1114, 472);
            this.tabControl1.TabIndex = 60;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnSalvarPedido);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lblEstoque);
            this.tabPage1.Controls.Add(this.btnVoltar);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1106, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbFuncionarios);
            this.groupBox1.Controls.Add(this.cbClientes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.lblValorFinal);
            this.groupBox1.Location = new System.Drawing.Point(130, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 229);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // cbFuncionarios
            // 
            this.cbFuncionarios.FormattingEnabled = true;
            this.cbFuncionarios.Location = new System.Drawing.Point(202, 98);
            this.cbFuncionarios.Name = "cbFuncionarios";
            this.cbFuncionarios.Size = new System.Drawing.Size(590, 33);
            this.cbFuncionarios.TabIndex = 39;
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(202, 37);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(590, 33);
            this.cbClientes.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 28);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nome do Funcionário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nome do Cliente:";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.btnConsultarPedidos);
            this.tabPage2.Controls.Add(this.txtConsultapedidos);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.lblconsultarpedidos);
            this.tabPage2.Controls.Add(this.dgvConsultarPedidos);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1106, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnConsultarPedidos
            // 
            this.btnConsultarPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarPedidos.Image")));
            this.btnConsultarPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarPedidos.Location = new System.Drawing.Point(562, 63);
            this.btnConsultarPedidos.Name = "btnConsultarPedidos";
            this.btnConsultarPedidos.Size = new System.Drawing.Size(107, 32);
            this.btnConsultarPedidos.TabIndex = 12;
            this.btnConsultarPedidos.Text = "Consultar";
            this.btnConsultarPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarPedidos.UseVisualStyleBackColor = true;
            // 
            // txtConsultapedidos
            // 
            this.txtConsultapedidos.BackColor = System.Drawing.Color.Ivory;
            this.txtConsultapedidos.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtConsultapedidos.Location = new System.Drawing.Point(87, 63);
            this.txtConsultapedidos.MaxLength = 50;
            this.txtConsultapedidos.Name = "txtConsultapedidos";
            this.txtConsultapedidos.Size = new System.Drawing.Size(456, 32);
            this.txtConsultapedidos.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CaféPatronal.Properties.Resources.icon3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1047, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 57);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblconsultarpedidos
            // 
            this.lblconsultarpedidos.AutoSize = true;
            this.lblconsultarpedidos.BackColor = System.Drawing.Color.Transparent;
            this.lblconsultarpedidos.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconsultarpedidos.Location = new System.Drawing.Point(2, 3);
            this.lblconsultarpedidos.Name = "lblconsultarpedidos";
            this.lblconsultarpedidos.Size = new System.Drawing.Size(196, 34);
            this.lblconsultarpedidos.TabIndex = 7;
            this.lblconsultarpedidos.Text = "CONSULTA DE PEDIDOS";
            // 
            // dgvConsultarPedidos
            // 
            this.dgvConsultarPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarPedidos.Location = new System.Drawing.Point(87, 101);
            this.dgvConsultarPedidos.Name = "dgvConsultarPedidos";
            this.dgvConsultarPedidos.Size = new System.Drawing.Size(910, 313);
            this.dgvConsultarPedidos.TabIndex = 6;
            // 
            // BtnSalvarPedido
            // 
            this.BtnSalvarPedido.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSalvarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvarPedido.FlatAppearance.BorderSize = 0;
            this.BtnSalvarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalvarPedido.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvarPedido.Image")));
            this.BtnSalvarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvarPedido.Location = new System.Drawing.Point(974, 392);
            this.BtnSalvarPedido.Name = "BtnSalvarPedido";
            this.BtnSalvarPedido.Size = new System.Drawing.Size(126, 36);
            this.BtnSalvarPedido.TabIndex = 68;
            this.BtnSalvarPedido.Text = "Salvar";
            this.BtnSalvarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvarPedido.UseVisualStyleBackColor = false;
            // 
            // CadastrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 536);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarPedido";
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValorFinal;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblconsultarpedidos;
        private System.Windows.Forms.DataGridView dgvConsultarPedidos;
        private System.Windows.Forms.Button btnConsultarPedidos;
        private System.Windows.Forms.TextBox txtConsultapedidos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbFuncionarios;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSalvarPedido;
    }
}