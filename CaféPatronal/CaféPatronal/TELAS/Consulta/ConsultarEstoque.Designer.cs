namespace CaféPatronal.TELAS.Consulta
{
    partial class ConsultarEstoque
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
            this.lblconsultaestoque = new System.Windows.Forms.Label();
            this.dgvconsultaestoq = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultaestoq)).BeginInit();
            this.SuspendLayout();
            // 
            // lblconsultaestoque
            // 
            this.lblconsultaestoque.AutoSize = true;
            this.lblconsultaestoque.BackColor = System.Drawing.Color.Transparent;
            this.lblconsultaestoque.Font = new System.Drawing.Font("Agency FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconsultaestoque.Location = new System.Drawing.Point(425, 31);
            this.lblconsultaestoque.Name = "lblconsultaestoque";
            this.lblconsultaestoque.Size = new System.Drawing.Size(198, 34);
            this.lblconsultaestoque.TabIndex = 3;
            this.lblconsultaestoque.Text = "CONSULTA DE ESTOQUE";
            // 
            // dgvconsultaestoq
            // 
            this.dgvconsultaestoq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsultaestoq.Location = new System.Drawing.Point(131, 111);
            this.dgvconsultaestoq.Name = "dgvconsultaestoq";
            this.dgvconsultaestoq.Size = new System.Drawing.Size(917, 394);
            this.dgvconsultaestoq.TabIndex = 2;
            // 
            // ConsultarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CaféPatronal.Properties.Resources.cafe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 536);
            this.Controls.Add(this.lblconsultaestoque);
            this.Controls.Add(this.dgvconsultaestoq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarEstoque";
            this.Text = "ConsultarEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultaestoq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblconsultaestoque;
        private System.Windows.Forms.DataGridView dgvconsultaestoq;
    }
}