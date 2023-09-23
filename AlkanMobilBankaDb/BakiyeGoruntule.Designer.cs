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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BakiyeGoruntule));
            label2 = new Label();
            lblBakiye = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(440, 275);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(225, 52);
            label2.TabIndex = 9;
            label2.Text = "Hesabınızda Bulunan \r\nBakiye  Tutarı (TL) :";
            label2.Click += label2_Click;
            // 
            // lblBakiye
            // 
            lblBakiye.AutoSize = true;
            lblBakiye.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblBakiye.Location = new Point(477, 374);
            lblBakiye.Margin = new Padding(7, 0, 7, 0);
            lblBakiye.Name = "lblBakiye";
            lblBakiye.Size = new Size(25, 43);
            lblBakiye.TabIndex = 10;
            lblBakiye.Text = ".";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(453, 56);
            label6.Name = "label6";
            label6.Size = new Size(617, 100);
            label6.TabIndex = 24;
            label6.Text = "Bakiye Görüntüleme Ekranına Hoşgeldiniz\r\n\r\n";
            // 
            // BakiyeGoruntule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1082, 703);
            Controls.Add(label6);
            Controls.Add(lblBakiye);
            Controls.Add(label2);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "BakiyeGoruntule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BakiyeGoruntule";
            Load += BakiyeGoruntule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label lblBakiye;
        private Label label6;
    }
}