namespace AlkanMobilBankaDb
{
    partial class musteriİslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(musteriİslem));
            groupBox1 = new GroupBox();
            btnHareketGor = new Button();
            btnOturumKapat = new Button();
            btnParaGonder = new Button();
            btnParaYatır = new Button();
            btnParolaGuncelle = new Button();
            btnBakiyeGor = new Button();
            btnParaCek = new Button();
            label1 = new Label();
            lblAdSoyad = new Label();
            lblHesapNo = new Label();
            label4 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(btnHareketGor);
            groupBox1.Controls.Add(btnOturumKapat);
            groupBox1.Controls.Add(btnParaGonder);
            groupBox1.Controls.Add(btnParaYatır);
            groupBox1.Controls.Add(btnParolaGuncelle);
            groupBox1.Controls.Add(btnBakiyeGor);
            groupBox1.Controls.Add(btnParaCek);
            groupBox1.Location = new Point(470, 180);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(550, 450);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // btnHareketGor
            // 
            btnHareketGor.BackColor = Color.Coral;
            btnHareketGor.BackgroundImage = (Image)resources.GetObject("btnHareketGor.BackgroundImage");
            btnHareketGor.BackgroundImageLayout = ImageLayout.Stretch;
            btnHareketGor.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnHareketGor.ForeColor = SystemColors.Control;
            btnHareketGor.Location = new Point(299, 241);
            btnHareketGor.Margin = new Padding(3, 4, 3, 4);
            btnHareketGor.Name = "btnHareketGor";
            btnHareketGor.Size = new Size(230, 70);
            btnHareketGor.TabIndex = 6;
            btnHareketGor.Text = "Hesap Hareketleri";
            btnHareketGor.UseVisualStyleBackColor = false;
            btnHareketGor.Click += btnHareketGor_Click;
            // 
            // btnOturumKapat
            // 
            btnOturumKapat.BackColor = Color.Red;
            btnOturumKapat.BackgroundImage = (Image)resources.GetObject("btnOturumKapat.BackgroundImage");
            btnOturumKapat.BackgroundImageLayout = ImageLayout.Stretch;
            btnOturumKapat.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOturumKapat.ForeColor = SystemColors.ButtonHighlight;
            btnOturumKapat.Image = (Image)resources.GetObject("btnOturumKapat.Image");
            btnOturumKapat.ImageAlign = ContentAlignment.BottomCenter;
            btnOturumKapat.Location = new Point(160, 353);
            btnOturumKapat.Margin = new Padding(3, 4, 3, 4);
            btnOturumKapat.Name = "btnOturumKapat";
            btnOturumKapat.Size = new Size(229, 54);
            btnOturumKapat.TabIndex = 5;
            btnOturumKapat.Text = "Oturumu Sonlandır";
            btnOturumKapat.UseVisualStyleBackColor = false;
            btnOturumKapat.Click += btnOturumKapat_Click;
            // 
            // btnParaGonder
            // 
            btnParaGonder.BackColor = SystemColors.ControlDarkDark;
            btnParaGonder.BackgroundImage = (Image)resources.GetObject("btnParaGonder.BackgroundImage");
            btnParaGonder.BackgroundImageLayout = ImageLayout.Stretch;
            btnParaGonder.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnParaGonder.ForeColor = SystemColors.Control;
            btnParaGonder.Location = new Point(299, 132);
            btnParaGonder.Margin = new Padding(3, 4, 3, 4);
            btnParaGonder.Name = "btnParaGonder";
            btnParaGonder.Size = new Size(230, 70);
            btnParaGonder.TabIndex = 4;
            btnParaGonder.Text = "Havale/EFT Para Gönderimi";
            btnParaGonder.UseVisualStyleBackColor = false;
            btnParaGonder.Click += btnParaGonder_Click;
            // 
            // btnParaYatır
            // 
            btnParaYatır.BackColor = Color.Salmon;
            btnParaYatır.BackgroundImage = (Image)resources.GetObject("btnParaYatır.BackgroundImage");
            btnParaYatır.BackgroundImageLayout = ImageLayout.Stretch;
            btnParaYatır.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnParaYatır.ForeColor = SystemColors.Control;
            btnParaYatır.Location = new Point(299, 41);
            btnParaYatır.Margin = new Padding(3, 4, 3, 4);
            btnParaYatır.Name = "btnParaYatır";
            btnParaYatır.Size = new Size(230, 70);
            btnParaYatır.TabIndex = 3;
            btnParaYatır.Text = "Para Yatırma";
            btnParaYatır.UseVisualStyleBackColor = false;
            btnParaYatır.Click += btnParaYatır_Click;
            // 
            // btnParolaGuncelle
            // 
            btnParolaGuncelle.BackColor = Color.SaddleBrown;
            btnParolaGuncelle.BackgroundImage = (Image)resources.GetObject("btnParolaGuncelle.BackgroundImage");
            btnParolaGuncelle.BackgroundImageLayout = ImageLayout.Stretch;
            btnParolaGuncelle.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnParolaGuncelle.ForeColor = SystemColors.Control;
            btnParolaGuncelle.Location = new Point(22, 241);
            btnParolaGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnParolaGuncelle.Name = "btnParolaGuncelle";
            btnParolaGuncelle.Size = new Size(230, 70);
            btnParolaGuncelle.TabIndex = 2;
            btnParolaGuncelle.Text = "Şifre Güncelle";
            btnParolaGuncelle.UseVisualStyleBackColor = false;
            btnParolaGuncelle.Click += btnParolaGuncelle_Click;
            // 
            // btnBakiyeGor
            // 
            btnBakiyeGor.BackColor = Color.Yellow;
            btnBakiyeGor.BackgroundImage = (Image)resources.GetObject("btnBakiyeGor.BackgroundImage");
            btnBakiyeGor.BackgroundImageLayout = ImageLayout.Stretch;
            btnBakiyeGor.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnBakiyeGor.ForeColor = SystemColors.Control;
            btnBakiyeGor.Location = new Point(22, 132);
            btnBakiyeGor.Margin = new Padding(3, 4, 3, 4);
            btnBakiyeGor.Name = "btnBakiyeGor";
            btnBakiyeGor.Size = new Size(230, 70);
            btnBakiyeGor.TabIndex = 1;
            btnBakiyeGor.Text = "Bakiye Görüntüle";
            btnBakiyeGor.UseVisualStyleBackColor = false;
            btnBakiyeGor.Click += btnBakiyeGor_Click;
            // 
            // btnParaCek
            // 
            btnParaCek.BackColor = Color.YellowGreen;
            btnParaCek.BackgroundImage = (Image)resources.GetObject("btnParaCek.BackgroundImage");
            btnParaCek.BackgroundImageLayout = ImageLayout.Stretch;
            btnParaCek.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnParaCek.ForeColor = Color.White;
            btnParaCek.Location = new Point(22, 42);
            btnParaCek.Margin = new Padding(3, 4, 3, 4);
            btnParaCek.Name = "btnParaCek";
            btnParaCek.Size = new Size(230, 70);
            btnParaCek.TabIndex = 0;
            btnParaCek.Text = "Para Çek";
            btnParaCek.UseVisualStyleBackColor = false;
            btnParaCek.Click += btnParaCek_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(112, 221);
            label1.Name = "label1";
            label1.Size = new Size(276, 32);
            label1.TabIndex = 3;
            label1.Text = "Ad Soyad :                    \r\n";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdSoyad.Location = new Point(112, 275);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(245, 32);
            lblAdSoyad.TabIndex = 4;
            lblAdSoyad.Text = ".                                ";
            // 
            // lblHesapNo
            // 
            lblHesapNo.AutoSize = true;
            lblHesapNo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHesapNo.Location = new Point(112, 401);
            lblHesapNo.Name = "lblHesapNo";
            lblHesapNo.Size = new Size(245, 32);
            lblHesapNo.TabIndex = 6;
            lblHesapNo.Text = ".                                ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(112, 339);
            label4.Name = "label4";
            label4.Size = new Size(279, 32);
            label4.TabIndex = 5;
            label4.Text = "Hesap No :                    ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(470, 51);
            label6.Name = "label6";
            label6.Size = new Size(510, 47);
            label6.TabIndex = 41;
            label6.Text = "Müşteri İşlem Ekranına Hoşgeldiniz ";
            // 
            // musteriİslem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1082, 703);
            Controls.Add(label6);
            Controls.Add(lblHesapNo);
            Controls.Add(label4);
            Controls.Add(lblAdSoyad);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "musteriİslem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "musteriİslem";
            Load += musteriİslem_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnOturumKapat;
        private Button btnParaGonder;
        private Button btnParaYatır;
        private Button btnParolaGuncelle;
        private Button btnBakiyeGor;
        private Button btnParaCek;
        private Label label1;
        private Label lblAdSoyad;
        private Label lblHesapNo;
        private Label label4;
        private Button btnHareketGor;
        private Label label6;
    }
}