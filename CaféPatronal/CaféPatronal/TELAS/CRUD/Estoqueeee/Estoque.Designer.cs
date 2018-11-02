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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvué = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblconsultadclientre = new System.Windows.Forms.Label();
            this.btnConsultarestoque = new System.Windows.Forms.Button();
            this.txtConsultarEstoque = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.cbProduto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAtual = new System.Windows.Forms.Label();
            this.BtnSalvarCompra = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvué)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(44, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1088, 507);
            this.tabControl1.TabIndex = 61;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Linen;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.dgvué);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.lblconsultadclientre);
            this.tabPage2.Controls.Add(this.btnConsultarestoque);
            this.tabPage2.Controls.Add(this.txtConsultarEstoque);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1080, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            // 
            // dgvué
            // 
            this.dgvué.AllowUserToAddRows = false;
            this.dgvué.AllowUserToDeleteRows = false;
            this.dgvué.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvué.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvué.Location = new System.Drawing.Point(11, 115);
            this.dgvué.Name = "dgvué";
            this.dgvué.ReadOnly = true;
            this.dgvué.RowHeadersVisible = false;
            this.dgvué.Size = new System.Drawing.Size(1030, 343);
            this.dgvué.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nm_produtocompra";
            this.dataGridViewTextBoxColumn1.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ds_quantidade";
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
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
            // lblconsultadclientre
            // 
            this.lblconsultadclientre.AutoSize = true;
            this.lblconsultadclientre.BackColor = System.Drawing.Color.Transparent;
            this.lblconsultadclientre.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconsultadclientre.Location = new System.Drawing.Point(2, 8);
            this.lblconsultadclientre.Name = "lblconsultadclientre";
            this.lblconsultadclientre.Size = new System.Drawing.Size(85, 34);
            this.lblconsultadclientre.TabIndex = 12;
            this.lblconsultadclientre.Text = "ESTOQUE\r\n";
            // 
            // btnConsultarestoque
            // 
            this.btnConsultarestoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarestoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarestoque.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarestoque.Image")));
            this.btnConsultarestoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarestoque.Location = new System.Drawing.Point(473, 74);
            this.btnConsultarestoque.Name = "btnConsultarestoque";
            this.btnConsultarestoque.Size = new System.Drawing.Size(107, 38);
            this.btnConsultarestoque.TabIndex = 2;
            this.btnConsultarestoque.Text = "Consultar";
            this.btnConsultarestoque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarestoque.UseVisualStyleBackColor = true;
            this.btnConsultarestoque.Click += new System.EventHandler(this.btnConsultarestoque_Click);
            // 
            // txtConsultarEstoque
            // 
            this.txtConsultarEstoque.BackColor = System.Drawing.Color.Ivory;
            this.txtConsultarEstoque.Location = new System.Drawing.Point(11, 77);
            this.txtConsultarEstoque.MaxLength = 50;
            this.txtConsultarEstoque.Name = "txtConsultarEstoque";
            this.txtConsultarEstoque.Size = new System.Drawing.Size(456, 32);
            this.txtConsultarEstoque.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Linen;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.BtnSalvarCompra);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1080, 469);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Baixa de Estoque";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Pesquisar);
            this.groupBox1.Controls.Add(this.cbProduto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudQtd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblAtual);
            this.groupBox1.Location = new System.Drawing.Point(22, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 181);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            // 
            // Pesquisar
            // 
            this.Pesquisar.FlatAppearance.BorderSize = 0;
            this.Pesquisar.Location = new System.Drawing.Point(285, 31);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(81, 34);
            this.Pesquisar.TabIndex = 2;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Pesquisar.UseVisualStyleBackColor = true;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // cbProduto
            // 
            this.cbProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProduto.FormattingEnabled = true;
            this.cbProduto.Location = new System.Drawing.Point(115, 31);
            this.cbProduto.Name = "cbProduto";
            this.cbProduto.Size = new System.Drawing.Size(154, 33);
            this.cbProduto.TabIndex = 1;
            this.cbProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbProduto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Produto";
            // 
            // nudQtd
            // 
            this.nudQtd.Location = new System.Drawing.Point(115, 125);
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(154, 32);
            this.nudQtd.TabIndex = 3;
            this.nudQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudQtd_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Atual ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Quantidade";
            // 
            // lblAtual
            // 
            this.lblAtual.AutoSize = true;
            this.lblAtual.Location = new System.Drawing.Point(126, 80);
            this.lblAtual.Name = "lblAtual";
            this.lblAtual.Size = new System.Drawing.Size(18, 25);
            this.lblAtual.TabIndex = 2;
            this.lblAtual.Text = "-";
            // 
            // BtnSalvarCompra
            // 
            this.BtnSalvarCompra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSalvarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvarCompra.FlatAppearance.BorderSize = 0;
            this.BtnSalvarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalvarCompra.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvarCompra.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvarCompra.Image")));
            this.BtnSalvarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvarCompra.Location = new System.Drawing.Point(946, 425);
            this.BtnSalvarCompra.Name = "BtnSalvarCompra";
            this.BtnSalvarCompra.Size = new System.Drawing.Size(126, 36);
            this.BtnSalvarCompra.TabIndex = 4;
            this.BtnSalvarCompra.Text = "Dar Baixa";
            this.BtnSalvarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvarCompra.UseVisualStyleBackColor = false;
            this.BtnSalvarCompra.Click += new System.EventHandler(this.BtnSalvarCompra_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::CaféPatronal.Properties.Resources.icon3;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(1013, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 57);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "ESTOQUE\r\n";
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvué)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblconsultadclientre;
        private System.Windows.Forms.Button btnConsultarestoque;
        private System.Windows.Forms.TextBox txtConsultarEstoque;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudQtd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAtual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSalvarCompra;
        private System.Windows.Forms.DataGridView dgvué;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button Pesquisar;
    }
}