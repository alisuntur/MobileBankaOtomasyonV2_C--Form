﻿namespace AlkanMobilBankaDb
{
    partial class PasifHesapAc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasifHesapAc));
            btnSil = new Button();
            txtID = new TextBox();
            label9 = new Label();
            txtDurum = new TextBox();
            label8 = new Label();
            txtVerilenBilgi = new TextBox();
            label7 = new Label();
            button1 = new Button();
            txtBakiye = new MaskedTextBox();
            txtTelefon = new MaskedTextBox();
            txtAdres = new TextBox();
            txtAdSoyad = new TextBox();
            txtTcKimlikNo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.Location = new Point(739, 598);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(278, 62);
            btnSil.TabIndex = 68;
            btnSil.Text = "Hesabı Aktifleştir";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(428, 206);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.MaxLength = 11;
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(239, 34);
            txtID.TabIndex = 84;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(217, 212);
            label9.Name = "label9";
            label9.Size = new Size(142, 29);
            label9.TabIndex = 85;
            label9.Text = "Müşteri No :";
            // 
            // txtDurum
            // 
            txtDurum.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDurum.Location = new Point(428, 626);
            txtDurum.Margin = new Padding(3, 4, 3, 4);
            txtDurum.MaxLength = 11;
            txtDurum.Name = "txtDurum";
            txtDurum.ReadOnly = true;
            txtDurum.Size = new Size(239, 34);
            txtDurum.TabIndex = 82;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(217, 629);
            label8.Name = "label8";
            label8.Size = new Size(185, 29);
            label8.TabIndex = 83;
            label8.Text = "Hesap Durumu :";
            // 
            // txtVerilenBilgi
            // 
            txtVerilenBilgi.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtVerilenBilgi.Location = new Point(428, 138);
            txtVerilenBilgi.Margin = new Padding(3, 4, 3, 4);
            txtVerilenBilgi.MaxLength = 12;
            txtVerilenBilgi.Name = "txtVerilenBilgi";
            txtVerilenBilgi.Size = new Size(239, 34);
            txtVerilenBilgi.TabIndex = 80;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(217, 144);
            label7.Name = "label7";
            label7.Size = new Size(192, 29);
            label7.TabIndex = 81;
            label7.Text = "ID/TC Kimlik No:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(739, 138);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(278, 62);
            button1.TabIndex = 67;
            button1.Text = "Bilgileri Getir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBakiye
            // 
            txtBakiye.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBakiye.Location = new Point(428, 561);
            txtBakiye.Margin = new Padding(3, 4, 3, 4);
            txtBakiye.Mask = "000000000000";
            txtBakiye.Name = "txtBakiye";
            txtBakiye.ReadOnly = true;
            txtBakiye.Size = new Size(239, 34);
            txtBakiye.TabIndex = 77;
            txtBakiye.ValidatingType = typeof(int);
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefon.Location = new Point(429, 491);
            txtTelefon.Margin = new Padding(3, 4, 3, 4);
            txtTelefon.Mask = "(999) 000-0000";
            txtTelefon.Name = "txtTelefon";
            txtTelefon.ReadOnly = true;
            txtTelefon.Size = new Size(238, 34);
            txtTelefon.TabIndex = 75;
            // 
            // txtAdres
            // 
            txtAdres.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdres.Location = new Point(428, 417);
            txtAdres.Margin = new Padding(3, 4, 3, 4);
            txtAdres.Name = "txtAdres";
            txtAdres.ReadOnly = true;
            txtAdres.Size = new Size(239, 34);
            txtAdres.TabIndex = 73;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdSoyad.Location = new Point(428, 345);
            txtAdSoyad.Margin = new Padding(3, 4, 3, 4);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.ReadOnly = true;
            txtAdSoyad.Size = new Size(239, 34);
            txtAdSoyad.TabIndex = 71;
            // 
            // txtTcKimlikNo
            // 
            txtTcKimlikNo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTcKimlikNo.Location = new Point(428, 270);
            txtTcKimlikNo.Margin = new Padding(3, 4, 3, 4);
            txtTcKimlikNo.MaxLength = 11;
            txtTcKimlikNo.Name = "txtTcKimlikNo";
            txtTcKimlikNo.ReadOnly = true;
            txtTcKimlikNo.Size = new Size(239, 34);
            txtTcKimlikNo.TabIndex = 69;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(428, 46);
            label6.Name = "label6";
            label6.Size = new Size(611, 47);
            label6.TabIndex = 79;
            label6.Text = " Hesap Aktifleştirme Sayfasına Hoşgeldiniz ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(217, 564);
            label5.Name = "label5";
            label5.Size = new Size(97, 29);
            label5.TabIndex = 78;
            label5.Text = "Bakiye :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(217, 494);
            label4.Name = "label4";
            label4.Size = new Size(102, 29);
            label4.TabIndex = 76;
            label4.Text = "Telefon:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(217, 423);
            label3.Name = "label3";
            label3.Size = new Size(88, 29);
            label3.TabIndex = 74;
            label3.Text = "Adres :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(217, 353);
            label2.Name = "label2";
            label2.Size = new Size(122, 29);
            label2.TabIndex = 72;
            label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(217, 273);
            label1.Name = "label1";
            label1.Size = new Size(168, 29);
            label1.TabIndex = 70;
            label1.Text = "TC Kimlik No :";
            // 
            // PasifHesapAc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1082, 703);
            Controls.Add(btnSil);
            Controls.Add(txtID);
            Controls.Add(label9);
            Controls.Add(txtDurum);
            Controls.Add(label8);
            Controls.Add(txtVerilenBilgi);
            Controls.Add(label7);
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
            Name = "PasifHesapAc";
            Text = "PasifHesapAc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSil;
        private TextBox txtID;
        private Label label9;
        private TextBox txtDurum;
        private Label label8;
        private TextBox txtVerilenBilgi;
        private Label label7;
        private Button button1;
        private MaskedTextBox txtBakiye;
        private MaskedTextBox txtTelefon;
        private TextBox txtAdres;
        private TextBox txtAdSoyad;
        private TextBox txtTcKimlikNo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}