namespace CaféPatronal.TELAS.Consulta
{
    partial class ControleDeVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleDeVenda));
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.tbControleVendas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblconsultaproduto = new System.Windows.Forms.Label();
            this.dgvControleVendas = new System.Windows.Forms.DataGridView();
            this.btnConsultarVendas = new System.Windows.Forms.Button();
            this.txtConsultarVendas = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.tbControleVendas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControleVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::CaféPatronal.Properties.Resources.icon3;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(981, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(59, 57);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tbControleVendas
            // 
            this.tbControleVendas.Controls.Add(this.tabPage1);
            this.tbControleVendas.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControleVendas.Location = new System.Drawing.Point(12, 12);
            this.tbControleVendas.Name = "tbControleVendas";
            this.tbControleVendas.SelectedIndex = 0;
            this.tbControleVendas.Size = new System.Drawing.Size(1056, 509);
            this.tbControleVendas.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.lblconsultaproduto);
            this.tabPage1.Controls.Add(this.dgvControleVendas);
            this.tabPage1.Controls.Add(this.btnConsultarVendas);
            this.tabPage1.Controls.Add(this.txtConsultarVendas);
            this.tabPage1.Controls.Add(this.btnVoltar);
            this.tabPage1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 41);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1048, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Controle de Vendas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblconsultaproduto
            // 
            this.lblconsultaproduto.AutoSize = true;
            this.lblconsultaproduto.BackColor = System.Drawing.Color.Transparent;
            this.lblconsultaproduto.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconsultaproduto.Location = new System.Drawing.Point(6, 3);
            this.lblconsultaproduto.Name = "lblconsultaproduto";
            this.lblconsultaproduto.Size = new System.Drawing.Size(77, 34);
            this.lblconsultaproduto.TabIndex = 17;
            this.lblconsultaproduto.Text = "VENDAS";
            // 
            // dgvControleVendas
            // 
            this.dgvControleVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControleVendas.Location = new System.Drawing.Point(61, 95);
            this.dgvControleVendas.Name = "dgvControleVendas";
            this.dgvControleVendas.Size = new System.Drawing.Size(915, 322);
            this.dgvControleVendas.TabIndex = 16;
            // 
            // btnConsultarVendas
            // 
            this.btnConsultarVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarVendas.Image")));
            this.btnConsultarVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarVendas.Location = new System.Drawing.Point(521, 57);
            this.btnConsultarVendas.Name = "btnConsultarVendas";
            this.btnConsultarVendas.Size = new System.Drawing.Size(107, 32);
            this.btnConsultarVendas.TabIndex = 15;
            this.btnConsultarVendas.Text = "Consultar";
            this.btnConsultarVendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarVendas.UseVisualStyleBackColor = true;
            // 
            // txtConsultarVendas
            // 
            this.txtConsultarVendas.BackColor = System.Drawing.Color.Ivory;
            this.txtConsultarVendas.Location = new System.Drawing.Point(59, 58);
            this.txtConsultarVendas.MaxLength = 50;
            this.txtConsultarVendas.Name = "txtConsultarVendas";
            this.txtConsultarVendas.Size = new System.Drawing.Size(456, 30);
            this.txtConsultarVendas.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(743, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 33);
            this.button2.TabIndex = 19;
            this.button2.Text = "Alterar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(634, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Apagar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ControleDeVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1104, 551);
            this.Controls.Add(this.tbControleVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControleDeVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleDeVenda";
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.tbControleVendas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControleVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.TabControl tbControleVendas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvControleVendas;
        private System.Windows.Forms.Button btnConsultarVendas;
        private System.Windows.Forms.TextBox txtConsultarVendas;
        private System.Windows.Forms.Label lblconsultaproduto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}