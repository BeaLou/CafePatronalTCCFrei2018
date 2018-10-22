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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvconsultaestoq = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblconsultadclientre = new System.Windows.Forms.Label();
            this.btnConsultarestoque = new System.Windows.Forms.Button();
            this.txtConsultarEstoque = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultaestoq)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
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
            this.tabPage2.Text = "Consulta";
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
            this.dgvconsultaestoq.AllowUserToAddRows = false;
            this.dgvconsultaestoq.AllowUserToDeleteRows = false;
            this.dgvconsultaestoq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsultaestoq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvconsultaestoq.Location = new System.Drawing.Point(8, 118);
            this.dgvconsultaestoq.Name = "dgvconsultaestoq";
            this.dgvconsultaestoq.ReadOnly = true;
            this.dgvconsultaestoq.Size = new System.Drawing.Size(1047, 329);
            this.dgvconsultaestoq.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Compra";
            this.Column1.HeaderText = "Compra";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Fornecedor";
            this.Column2.HeaderText = "Fornecedor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Quantidade";
            this.Column3.HeaderText = "Quantidade";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Data";
            this.Column4.HeaderText = "Data";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
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
            this.btnConsultarestoque.TabIndex = 10;
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultaestoq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblconsultadclientre;
        private System.Windows.Forms.Button btnConsultarestoque;
        private System.Windows.Forms.TextBox txtConsultarEstoque;
        private System.Windows.Forms.DataGridView dgvconsultaestoq;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}