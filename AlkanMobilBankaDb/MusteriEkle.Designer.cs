namespace AlkanMobilBankaDb
{
    partial class MusteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriEkle));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTcKimlikNo = new TextBox();
            txtAdSoyad = new TextBox();
            txtAdres = new TextBox();
            txtTelefon = new MaskedTextBox();
            txtBakiye = new MaskedTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(141, 154);
            label1.Name = "label1";
            label1.Size = new Size(168, 29);
            label1.TabIndex = 0;
            label1.Text = "TC Kimlik No :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(141, 226);
            label2.Name = "label2";
            label2.Size = new Size(122, 29);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(141, 298);
            label3.Name = "label3";
            label3.Size = new Size(88, 29);
            label3.TabIndex = 2;
            label3.Text = "Adres :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(141, 370);
            label4.Name = "label4";
            label4.Size = new Size(102, 29);
            label4.TabIndex = 3;
            label4.Text = "Telefon:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(141, 442);
            label5.Name = "label5";
            label5.Size = new Size(97, 29);
            label5.TabIndex = 4;
            label5.Text = "Bakiye :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(438, 45);
            label6.Name = "label6";
            label6.Size = new Size(527, 47);
            label6.TabIndex = 5;
            label6.Text = "Müşteri Ekleme Ekranına Hoşgeldiniz";
            label6.Click += label6_Click;
            // 
            // txtTcKimlikNo
            // 
            txtTcKimlikNo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTcKimlikNo.Location = new Point(363, 151);
            txtTcKimlikNo.Margin = new Padding(3, 4, 3, 4);
            txtTcKimlikNo.MaxLength = 11;
            txtTcKimlikNo.Name = "txtTcKimlikNo";
            txtTcKimlikNo.Size = new Size(230, 34);
            txtTcKimlikNo.TabIndex = 0;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdSoyad.Location = new Point(363, 223);
            txtAdSoyad.Margin = new Padding(3, 4, 3, 4);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(230, 34);
            txtAdSoyad.TabIndex = 1;
            // 
            // txtAdres
            // 
            txtAdres.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdres.Location = new Point(363, 298);
            txtAdres.Margin = new Padding(3, 4, 3, 4);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(230, 34);
            txtAdres.TabIndex = 2;
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefon.Location = new Point(363, 370);
            txtTelefon.Margin = new Padding(3, 4, 3, 4);
            txtTelefon.Mask = "(999) 000-0000";
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(229, 34);
            txtTelefon.TabIndex = 3;
            // 
            // txtBakiye
            // 
            txtBakiye.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBakiye.Location = new Point(363, 437);
            txtBakiye.Margin = new Padding(3, 4, 3, 4);
            txtBakiye.Mask = "000000000000";
            txtBakiye.Name = "txtBakiye";
            txtBakiye.Size = new Size(230, 34);
            txtBakiye.TabIndex = 4;
            txtBakiye.ValidatingType = typeof(int);
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(362, 538);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(230, 53);
            button1.TabIndex = 11;
            button1.Text = "Bilgileri Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MusteriEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1082, 703);
            Controls.Add(button1);
            Controls.Add(txtBakiye);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdres);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTcKimlikNo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MusteriEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Ekleme Sayfası";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTcKimlikNo;
        private TextBox txtAdSoyad;
        private TextBox txtAdres;
        private MaskedTextBox txtTelefon;
        private MaskedTextBox txtBakiye;
        private Button button1;
    }
}