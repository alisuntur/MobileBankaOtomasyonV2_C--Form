namespace AlkanMobilBankaDb
{
    partial class ParaGonder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaGonder));
            button1 = new Button();
            txtTutarGonderilen = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            txtAlıcıHesap = new MaskedTextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(333, 473);
            button1.Name = "button1";
            button1.Size = new Size(160, 48);
            button1.TabIndex = 11;
            button1.Text = "Para Gönder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTutarGonderilen
            // 
            txtTutarGonderilen.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtTutarGonderilen.Location = new Point(350, 398);
            txtTutarGonderilen.Mask = "000000000000000000";
            txtTutarGonderilen.Name = "txtTutarGonderilen";
            txtTutarGonderilen.Size = new Size(133, 36);
            txtTutarGonderilen.TabIndex = 10;
            txtTutarGonderilen.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(163, 346);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(509, 35);
            label2.TabIndex = 9;
            label2.Text = "Hesabınızdan Göndermek  İstediğiniz Tutar (TL) :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(417, 50);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(614, 40);
            label1.TabIndex = 8;
            label1.Text = "Para Gönderme (Havale-EFT) Ekranına Hoşgeldiniz";
            // 
            // txtAlıcıHesap
            // 
            txtAlıcıHesap.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtAlıcıHesap.Location = new Point(350, 261);
            txtAlıcıHesap.Mask = "000000000000000000";
            txtAlıcıHesap.Name = "txtAlıcıHesap";
            txtAlıcıHesap.Size = new Size(133, 36);
            txtAlıcıHesap.TabIndex = 13;
            txtAlıcıHesap.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(145, 210);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(550, 35);
            label3.TabIndex = 12;
            label3.Text = "Hesabınızdan Göndermek  İstediğiniz Alıcı Hesap No :";
            // 
            // ParaGonder
            // 
            AutoScaleDimensions = new SizeF(17F, 46F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1082, 703);
            Controls.Add(txtAlıcıHesap);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtTutarGonderilen);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(6, 7, 6, 7);
            Name = "ParaGonder";
            Text = "ParaGonder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MaskedTextBox txtTutarGonderilen;
        private Label label2;
        private Label label1;
        private MaskedTextBox txtAlıcıHesap;
        private Label label3;
    }
}