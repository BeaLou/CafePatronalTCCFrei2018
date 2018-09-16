namespace CaféPatronal.TELAS
{
    partial class Consulta_de_Fluxo_de_Caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_de_Fluxo_de_Caixa));
            this.dgvFluxodCaixa = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.tbControleVendas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnConsultarFluxo = new System.Windows.Forms.Button();
            this.txtConsultarFluxo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFluxodCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.tbControleVendas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFluxodCaixa
            // 
            this.dgvFluxodCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFluxodCaixa.Location = new System.Drawing.Point(59, 94);
            this.dgvFluxodCaixa.Name = "dgvFluxodCaixa";
            this.dgvFluxodCaixa.Size = new System.Drawing.Size(1002, 361);
            this.dgvFluxodCaixa.TabIndex = 0;
            this.dgvFluxodCaixa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFluxodCaixa_CellContentClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = global::CaféPatronal.Properties.Resources.icon3;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(1050, 6);
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
            this.tbControleVendas.Location = new System.Drawing.Point(30, 12);
            this.tbControleVendas.Name = "tbControleVendas";
            this.tbControleVendas.SelectedIndex = 0;
            this.tbControleVendas.Size = new System.Drawing.Size(1125, 518);
            this.tbControleVendas.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.dgvFluxodCaixa);
            this.tabPage1.Controls.Add(this.btnVoltar);
            this.tabPage1.Controls.Add(this.btnConsultarFluxo);
            this.tabPage1.Controls.Add(this.txtConsultarFluxo);
            this.tabPage1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 41);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1117, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fluxo de Caixa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnConsultarFluxo
            // 
            this.btnConsultarFluxo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarFluxo.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarFluxo.Image")));
            this.btnConsultarFluxo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarFluxo.Location = new System.Drawing.Point(521, 57);
            this.btnConsultarFluxo.Name = "btnConsultarFluxo";
            this.btnConsultarFluxo.Size = new System.Drawing.Size(107, 32);
            this.btnConsultarFluxo.TabIndex = 15;
            this.btnConsultarFluxo.Text = "Consultar";
            this.btnConsultarFluxo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarFluxo.UseVisualStyleBackColor = true;
            // 
            // txtConsultarFluxo
            // 
            this.txtConsultarFluxo.BackColor = System.Drawing.Color.Ivory;
            this.txtConsultarFluxo.Location = new System.Drawing.Point(59, 58);
            this.txtConsultarFluxo.MaxLength = 50;
            this.txtConsultarFluxo.Name = "txtConsultarFluxo";
            this.txtConsultarFluxo.Size = new System.Drawing.Size(456, 30);
            this.txtConsultarFluxo.TabIndex = 14;
            // 
            // Consulta_de_Fluxo_de_Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1195, 574);
            this.Controls.Add(this.tbControleVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consulta_de_Fluxo_de_Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta_de_Fluxo_de_Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFluxodCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.tbControleVendas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFluxodCaixa;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.TabControl tbControleVendas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnConsultarFluxo;
        private System.Windows.Forms.TextBox txtConsultarFluxo;
    }
}