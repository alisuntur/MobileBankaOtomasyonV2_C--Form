namespace AlkanMobilBankaDb
{
    partial class MusteriAra
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
            txtVerilenBilgi = new TextBox();
            label7 = new Label();
            txtDurum = new TextBox();
            label8 = new Label();
            txtID = new TextBox();
            label9 = new Label();
            txtbakiye2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(568, 96);
            button1.Name = "button1";
            button1.Size = new Size(195, 40);
            button1.TabIndex = 23;
            button1.Text = "Bilgileri Getir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBakiye
            // 
            txtBakiye.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBakiye.Location = new Point(332, 432);
            txtBakiye.Mask = "00000.0000000";
            txtBakiye.Name = "txtBakiye";
            txtBakiye.ReadOnly = true;
            txtBakiye.Size = new Size(202, 36);
            txtBakiye.TabIndex = 20;
            txtBakiye.ValidatingType = typeof(int);
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefon.Location = new Point(333, 380);
            txtTelefon.Mask = "(999) 000-0000";
            txtTelefon.Name = "txtTelefon";
            txtTelefon.ReadOnly = true;
            txtTelefon.Size = new Size(201, 36);
            txtTelefon.TabIndex = 18;
            // 
            // txtAdres
            // 
            txtAdres.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdres.Location = new Point(332, 324);
            txtAdres.Name = "txtAdres";
            txtAdres.ReadOnly = true;
            txtAdres.Size = new Size(202, 36);
            txtAdres.TabIndex = 16;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdSoyad.Location = new Point(332, 270);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.ReadOnly = true;
            txtAdSoyad.Size = new Size(202, 36);
            txtAdSoyad.TabIndex = 14;
            // 
            // txtTcKimlikNo
            // 
            txtTcKimlikNo.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTcKimlikNo.Location = new Point(332, 214);
            txtTcKimlikNo.MaxLength = 11;
            txtTcKimlikNo.Name = "txtTcKimlikNo";
            txtTcKimlikNo.ReadOnly = true;
            txtTcKimlikNo.Size = new Size(202, 36);
            txtTcKimlikNo.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(225, 31);
            label6.Name = "label6";
            label6.Size = new Size(432, 37);
            label6.TabIndex = 22;
            label6.Text = "Müsteri Arama Sayfasına Hoşgeldiniz ...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(202, 430);
            label5.Name = "label5";
            label5.Size = new Size(77, 35);
            label5.TabIndex = 21;
            label5.Text = "Bakiye :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(202, 376);
            label4.Name = "label4";
            label4.Size = new Size(80, 35);
            label4.TabIndex = 19;
            label4.Text = "Telefon:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(202, 322);
            label3.Name = "label3";
            label3.Size = new Size(69, 35);
            label3.TabIndex = 17;
            label3.Text = "Adres :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(202, 268);
            label2.Name = "label2";
            label2.Size = new Size(96, 35);
            label2.TabIndex = 15;
            label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(202, 214);
            label1.Name = "label1";
            label1.Size = new Size(127, 35);
            label1.TabIndex = 13;
            label1.Text = "TC Kimlik No :";
            // 
            // txtVerilenBilgi
            // 
            txtVerilenBilgi.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtVerilenBilgi.Location = new Point(342, 101);
            txtVerilenBilgi.MaxLength = 15;
            txtVerilenBilgi.Name = "txtVerilenBilgi";
            txtVerilenBilgi.Size = new Size(202, 36);
            txtVerilenBilgi.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(182, 101);
            label7.Name = "label7";
            label7.Size = new Size(152, 35);
            label7.TabIndex = 25;
            label7.Text = "ID/TC Kimlik No:";
            // 
            // txtDurum
            // 
            txtDurum.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDurum.Location = new Point(332, 481);
            txtDurum.MaxLength = 11;
            txtDurum.Name = "txtDurum";
            txtDurum.ReadOnly = true;
            txtDurum.Size = new Size(202, 36);
            txtDurum.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(179, 481);
            label8.Name = "label8";
            label8.Size = new Size(147, 35);
            label8.TabIndex = 27;
            label8.Text = "Hesap Durumu :";
            // 
            // txtID
            // 
            txtID.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(332, 166);
            txtID.MaxLength = 11;
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(202, 36);
            txtID.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(202, 166);
            label9.Name = "label9";
            label9.Size = new Size(114, 35);
            label9.TabIndex = 29;
            label9.Text = "Müşteri No :";
            // 
            // txtbakiye2
            // 
            txtbakiye2.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtbakiye2.Location = new Point(549, 432);
            txtbakiye2.MaxLength = 11;
            txtbakiye2.Name = "txtbakiye2";
            txtbakiye2.ReadOnly = true;
            txtbakiye2.Size = new Size(202, 36);
            txtbakiye2.TabIndex = 30;
            // 
            // MusteriAra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 602);
            Controls.Add(txtbakiye2);
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
            Name = "MusteriAra";
            Text = "MusteriAra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private TextBox txtVerilenBilgi;
        private Label label7;
        private TextBox txtDurum;
        private Label label8;
        private TextBox txtID;
        private Label label9;
        private TextBox txtbakiye2;
    }
}