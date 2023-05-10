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
            button1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(458, 282);
            button1.Name = "button1";
            button1.Size = new Size(105, 34);
            button1.TabIndex = 11;
            button1.Text = "Para Gönder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTutarGonderilen
            // 
            txtTutarGonderilen.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtTutarGonderilen.Location = new Point(485, 227);
            txtTutarGonderilen.Mask = "0000000000";
            txtTutarGonderilen.Name = "txtTutarGonderilen";
            txtTutarGonderilen.Size = new Size(64, 30);
            txtTutarGonderilen.TabIndex = 10;
            txtTutarGonderilen.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(127, 227);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(340, 23);
            label2.TabIndex = 9;
            label2.Text = "Hesabınızdan Göndermek  İstediğiniz Tutar (TL) :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(116, 84);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(578, 37);
            label1.TabIndex = 8;
            label1.Text = "Para Gönderme (Havale-EFT) Ekranına Hoşgeldiniz ..";
            // 
            // txtAlıcıHesap
            // 
            txtAlıcıHesap.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtAlıcıHesap.Location = new Point(485, 187);
            txtAlıcıHesap.Mask = "0000000000";
            txtAlıcıHesap.Name = "txtAlıcıHesap";
            txtAlıcıHesap.Size = new Size(64, 30);
            txtAlıcıHesap.TabIndex = 13;
            txtAlıcıHesap.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(103, 187);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(364, 23);
            label3.TabIndex = 12;
            label3.Text = "Hesabınızdan Göndermek  İstediğiniz Alıcı Hesap No :";
            // 
            // ParaGonder
            // 
            AutoScaleDimensions = new SizeF(13F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 575);
            Controls.Add(txtAlıcıHesap);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtTutarGonderilen);
            Controls.Add(label2);
            Controls.Add(label1);
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