namespace CaféPatronal.TELAS
{
    partial class Splashscreen
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
            this.lblCAfe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCAfe
            // 
            this.lblCAfe.AutoSize = true;
            this.lblCAfe.BackColor = System.Drawing.Color.Green;
            this.lblCAfe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCAfe.Font = new System.Drawing.Font("Agency FB", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCAfe.ForeColor = System.Drawing.Color.Khaki;
            this.lblCAfe.Location = new System.Drawing.Point(12, 109);
            this.lblCAfe.Name = "lblCAfe";
            this.lblCAfe.Size = new System.Drawing.Size(848, 97);
            this.lblCAfe.TabIndex = 0;
            this.lblCAfe.Text = "Bem-Vindo ao Café Patronal...";
            this.lblCAfe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Agency FB", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(308, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(891, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "... o  melhor café você encontra aqui!!";
            // 
            // Splashscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CaféPatronal.Properties.Resources.cafetop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1211, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCAfe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splashscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splashscreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCAfe;
        private System.Windows.Forms.Label label1;
    }
}