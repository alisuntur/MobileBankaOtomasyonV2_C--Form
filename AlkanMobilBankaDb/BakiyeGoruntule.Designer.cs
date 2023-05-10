namespace AlkanMobilBankaDb
{
    partial class BakiyeGoruntule
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
            label2 = new Label();
            label1 = new Label();
            lblBakiye = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(40, 180);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(423, 33);
            label2.TabIndex = 9;
            label2.Text = "Hesabınızda Bulunan Bakiye  Tutarı (TL) :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(163, 81);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(478, 37);
            label1.TabIndex = 8;
            label1.Text = "Bakiye Görüntüleme Ekranına Hoşgeldiniz ..";
            // 
            // lblBakiye
            // 
            lblBakiye.AutoSize = true;
            lblBakiye.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblBakiye.Location = new Point(499, 180);
            lblBakiye.Margin = new Padding(6, 0, 6, 0);
            lblBakiye.Name = "lblBakiye";
            lblBakiye.Size = new Size(20, 33);
            lblBakiye.TabIndex = 10;
            lblBakiye.Text = ".";
            // 
            // BakiyeGoruntule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBakiye);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BakiyeGoruntule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BakiyeGoruntule";
            Load += BakiyeGoruntule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label lblBakiye;
    }
}