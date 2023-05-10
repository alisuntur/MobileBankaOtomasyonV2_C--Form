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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Bisque;
            groupBox1.Controls.Add(btnHareketGor);
            groupBox1.Controls.Add(btnOturumKapat);
            groupBox1.Controls.Add(btnParaGonder);
            groupBox1.Controls.Add(btnParaYatır);
            groupBox1.Controls.Add(btnParolaGuncelle);
            groupBox1.Controls.Add(btnBakiyeGor);
            groupBox1.Controls.Add(btnParaCek);
            groupBox1.Location = new Point(196, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 334);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // btnHareketGor
            // 
            btnHareketGor.BackColor = Color.Coral;
            btnHareketGor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHareketGor.ForeColor = SystemColors.ControlText;
            btnHareketGor.Location = new Point(227, 181);
            btnHareketGor.Name = "btnHareketGor";
            btnHareketGor.Size = new Size(140, 49);
            btnHareketGor.TabIndex = 6;
            btnHareketGor.Text = "Hesap Hareketleri";
            btnHareketGor.UseVisualStyleBackColor = false;
            btnHareketGor.Click += btnHareketGor_Click;
            // 
            // btnOturumKapat
            // 
            btnOturumKapat.BackColor = Color.Red;
            btnOturumKapat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOturumKapat.ForeColor = SystemColors.ControlText;
            btnOturumKapat.Location = new Point(134, 257);
            btnOturumKapat.Name = "btnOturumKapat";
            btnOturumKapat.Size = new Size(140, 49);
            btnOturumKapat.TabIndex = 5;
            btnOturumKapat.Text = "Oturumu Sonlandır";
            btnOturumKapat.UseVisualStyleBackColor = false;
            btnOturumKapat.Click += btnOturumKapat_Click;
            // 
            // btnParaGonder
            // 
            btnParaGonder.BackColor = SystemColors.ControlDarkDark;
            btnParaGonder.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnParaGonder.ForeColor = SystemColors.ControlText;
            btnParaGonder.Location = new Point(227, 99);
            btnParaGonder.Name = "btnParaGonder";
            btnParaGonder.Size = new Size(140, 51);
            btnParaGonder.TabIndex = 4;
            btnParaGonder.Text = "Havale/EFT Para Gönderimi";
            btnParaGonder.UseVisualStyleBackColor = false;
            btnParaGonder.Click += btnParaGonder_Click;
            // 
            // btnParaYatır
            // 
            btnParaYatır.BackColor = Color.Salmon;
            btnParaYatır.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnParaYatır.ForeColor = SystemColors.ControlText;
            btnParaYatır.Location = new Point(227, 31);
            btnParaYatır.Name = "btnParaYatır";
            btnParaYatır.Size = new Size(140, 40);
            btnParaYatır.TabIndex = 3;
            btnParaYatır.Text = "Para Yatırma";
            btnParaYatır.UseVisualStyleBackColor = false;
            btnParaYatır.Click += btnParaYatır_Click;
            // 
            // btnParolaGuncelle
            // 
            btnParolaGuncelle.BackColor = Color.SaddleBrown;
            btnParolaGuncelle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnParolaGuncelle.ForeColor = SystemColors.ControlText;
            btnParolaGuncelle.Location = new Point(43, 181);
            btnParolaGuncelle.Name = "btnParolaGuncelle";
            btnParolaGuncelle.Size = new Size(140, 49);
            btnParolaGuncelle.TabIndex = 2;
            btnParolaGuncelle.Text = "Şifre Güncelle";
            btnParolaGuncelle.UseVisualStyleBackColor = false;
            btnParolaGuncelle.Click += btnParolaGuncelle_Click;
            // 
            // btnBakiyeGor
            // 
            btnBakiyeGor.BackColor = Color.Yellow;
            btnBakiyeGor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBakiyeGor.ForeColor = SystemColors.ControlText;
            btnBakiyeGor.Location = new Point(43, 99);
            btnBakiyeGor.Name = "btnBakiyeGor";
            btnBakiyeGor.Size = new Size(140, 44);
            btnBakiyeGor.TabIndex = 1;
            btnBakiyeGor.Text = "Bakiye Görüntüle";
            btnBakiyeGor.UseVisualStyleBackColor = false;
            btnBakiyeGor.Click += btnBakiyeGor_Click;
            // 
            // btnParaCek
            // 
            btnParaCek.BackColor = Color.YellowGreen;
            btnParaCek.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnParaCek.ForeColor = SystemColors.ControlText;
            btnParaCek.Location = new Point(43, 27);
            btnParaCek.Name = "btnParaCek";
            btnParaCek.Size = new Size(140, 48);
            btnParaCek.TabIndex = 0;
            btnParaCek.Text = "Para Çek";
            btnParaCek.UseVisualStyleBackColor = false;
            btnParaCek.Click += btnParaCek_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(164, 18);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 3;
            label1.Text = "Ad Soyad :";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdSoyad.Location = new Point(286, 18);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(17, 25);
            lblAdSoyad.TabIndex = 4;
            lblAdSoyad.Text = ".";
            // 
            // lblHesapNo
            // 
            lblHesapNo.AutoSize = true;
            lblHesapNo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblHesapNo.Location = new Point(286, 63);
            lblHesapNo.Name = "lblHesapNo";
            lblHesapNo.Size = new Size(17, 25);
            lblHesapNo.TabIndex = 6;
            lblHesapNo.Text = ".";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(164, 63);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 5;
            label4.Text = "Hesap No :";
            // 
            // musteriİslem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 575);
            Controls.Add(lblHesapNo);
            Controls.Add(label4);
            Controls.Add(lblAdSoyad);
            Controls.Add(label1);
            Controls.Add(groupBox1);
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
    }
}