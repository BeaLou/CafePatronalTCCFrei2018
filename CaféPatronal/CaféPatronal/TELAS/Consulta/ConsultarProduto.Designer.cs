namespace CaféPatronal.TELAS.Consulta
{
    partial class ConsultarProduto
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
            this.lblconsultaproduto = new System.Windows.Forms.Label();
            this.dgvconsultaproduto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultaproduto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblconsultaproduto
            // 
            this.lblconsultaproduto.AutoSize = true;
            this.lblconsultaproduto.BackColor = System.Drawing.Color.Transparent;
            this.lblconsultaproduto.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconsultaproduto.Location = new System.Drawing.Point(425, 31);
            this.lblconsultaproduto.Name = "lblconsultaproduto";
            this.lblconsultaproduto.Size = new System.Drawing.Size(213, 34);
            this.lblconsultaproduto.TabIndex = 3;
            this.lblconsultaproduto.Text = "CONSULTA DE PRODUTOS";
            // 
            // dgvconsultaproduto
            // 
            this.dgvconsultaproduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsultaproduto.Location = new System.Drawing.Point(131, 111);
            this.dgvconsultaproduto.Name = "dgvconsultaproduto";
            this.dgvconsultaproduto.Size = new System.Drawing.Size(917, 394);
            this.dgvconsultaproduto.TabIndex = 2;
            // 
            // ConsultarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CaféPatronal.Properties.Resources.cafe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 536);
            this.Controls.Add(this.lblconsultaproduto);
            this.Controls.Add(this.dgvconsultaproduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultaproduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblconsultaproduto;
        private System.Windows.Forms.DataGridView dgvconsultaproduto;
    }
}