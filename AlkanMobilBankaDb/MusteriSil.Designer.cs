namespace AlkanMobilBankaDb
{
    partial class MusteriSil
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
            btnSil.Location = new Point(513, 532);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(195, 40);
            btnSil.TabIndex = 2;
            btnSil.Text = "Müşteri Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(277, 219);
            txtID.MaxLength = 11;
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(202, 36);
            txtID.TabIndex = 65;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(147, 219);
            label9.Name = "label9";
            label9.Size = new Size(114, 35);
            label9.TabIndex = 66;
            label9.Text = "Müşteri No :";
            label9.Click += label9_Click;
            // 
            // txtDurum
            // 
            txtDurum.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDurum.Location = new Point(277, 534);
            txtDurum.MaxLength = 11;
            txtDurum.Name = "txtDurum";
            txtDurum.ReadOnly = true;
            txtDurum.Size = new Size(202, 36);
            txtDurum.TabIndex = 63;
            txtDurum.TextChanged += txtDurum_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(124, 534);
            label8.Name = "label8";
            label8.Size = new Size(147, 35);
            label8.TabIndex = 64;
            label8.Text = "Hesap Durumu :";
            label8.Click += label8_Click;
            // 
            // txtVerilenBilgi
            // 
            txtVerilenBilgi.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtVerilenBilgi.Location = new Point(287, 154);
            txtVerilenBilgi.MaxLength = 0;
            txtVerilenBilgi.Name = "txtVerilenBilgi";
            txtVerilenBilgi.Size = new Size(202, 36);
            txtVerilenBilgi.TabIndex = 61;
            txtVerilenBilgi.TextChanged += txtVerilenBilgi_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(127, 154);
            label7.Name = "label7";
            label7.Size = new Size(152, 35);
            label7.TabIndex = 62;
            label7.Text = "ID/TC Kimlik No:";
            label7.Click += label7_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(513, 149);
            button1.Name = "button1";
            button1.Size = new Size(195, 40);
            button1.TabIndex = 1;
            button1.Text = "Bilgileri Getir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBakiye
            // 
            txtBakiye.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBakiye.Location = new Point(277, 485);
            txtBakiye.Mask = "000000000000";
            txtBakiye.Name = "txtBakiye";
            txtBakiye.ReadOnly = true;
            txtBakiye.Size = new Size(202, 36);
            txtBakiye.TabIndex = 57;
            txtBakiye.ValidatingType = typeof(int);
            txtBakiye.MaskInputRejected += txtBakiye_MaskInputRejected;
            // 
            // txtTelefon
            // 
            txtTelefon.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefon.Location = new Point(278, 433);
            txtTelefon.Mask = "(999) 000-0000";
            txtTelefon.Name = "txtTelefon";
            txtTelefon.ReadOnly = true;
            txtTelefon.Size = new Size(201, 36);
            txtTelefon.TabIndex = 55;
            txtTelefon.MaskInputRejected += txtTelefon_MaskInputRejected;
            // 
            // txtAdres
            // 
            txtAdres.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdres.Location = new Point(277, 377);
            txtAdres.Name = "txtAdres";
            txtAdres.ReadOnly = true;
            txtAdres.Size = new Size(202, 36);
            txtAdres.TabIndex = 53;
            txtAdres.TextChanged += txtAdres_TextChanged;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdSoyad.Location = new Point(277, 323);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.ReadOnly = true;
            txtAdSoyad.Size = new Size(202, 36);
            txtAdSoyad.TabIndex = 51;
            txtAdSoyad.TextChanged += txtAdSoyad_TextChanged;
            // 
            // txtTcKimlikNo
            // 
            txtTcKimlikNo.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTcKimlikNo.Location = new Point(277, 267);
            txtTcKimlikNo.MaxLength = 11;
            txtTcKimlikNo.Name = "txtTcKimlikNo";
            txtTcKimlikNo.ReadOnly = true;
            txtTcKimlikNo.Size = new Size(202, 36);
            txtTcKimlikNo.TabIndex = 49;
            txtTcKimlikNo.TextChanged += txtTcKimlikNo_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(170, 84);
            label6.Name = "label6";
            label6.Size = new Size(417, 37);
            label6.TabIndex = 59;
            label6.Text = "Müsteri Silme Sayfasına Hoşgeldiniz ...";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(147, 483);
            label5.Name = "label5";
            label5.Size = new Size(77, 35);
            label5.TabIndex = 58;
            label5.Text = "Bakiye :";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(147, 429);
            label4.Name = "label4";
            label4.Size = new Size(80, 35);
            label4.TabIndex = 56;
            label4.Text = "Telefon:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(147, 375);
            label3.Name = "label3";
            label3.Size = new Size(69, 35);
            label3.TabIndex = 54;
            label3.Text = "Adres :";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(147, 321);
            label2.Name = "label2";
            label2.Size = new Size(96, 35);
            label2.TabIndex = 52;
            label2.Text = "Ad Soyad:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Reem Kufi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(147, 267);
            label1.Name = "label1";
            label1.Size = new Size(127, 35);
            label1.TabIndex = 50;
            label1.Text = "TC Kimlik No :";
            label1.Click += label1_Click;
            // 
            // MusteriSil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 657);
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
            Name = "MusteriSil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MusteriSil";
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