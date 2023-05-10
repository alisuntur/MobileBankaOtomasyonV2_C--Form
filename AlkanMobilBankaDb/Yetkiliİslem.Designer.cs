namespace AlkanMobilBankaDb
{
    partial class Yetkiliİslem
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnOturumKapat = new Button();
            btnListele = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnArama = new Button();
            btnEkle = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(208, 25);
            label1.Name = "label1";
            label1.Size = new Size(292, 25);
            label1.TabIndex = 0;
            label1.Text = "Sayın Yetkili Admin Hoşgeldiniz";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Bisque;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnOturumKapat);
            groupBox1.Controls.Add(btnListele);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnArama);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Location = new Point(150, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 334);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnOturumKapat
            // 
            btnOturumKapat.BackColor = Color.Red;
            btnOturumKapat.ForeColor = SystemColors.ControlText;
            btnOturumKapat.Location = new Point(135, 250);
            btnOturumKapat.Name = "btnOturumKapat";
            btnOturumKapat.Size = new Size(140, 40);
            btnOturumKapat.TabIndex = 5;
            btnOturumKapat.Text = "Oturumu Sonlandır";
            btnOturumKapat.UseVisualStyleBackColor = false;
            btnOturumKapat.Click += btnOturumKapat_Click;
            // 
            // btnListele
            // 
            btnListele.BackColor = SystemColors.ControlDarkDark;
            btnListele.ForeColor = SystemColors.ControlText;
            btnListele.Location = new Point(227, 106);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(140, 40);
            btnListele.TabIndex = 4;
            btnListele.Text = "Müşteri Listele";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Salmon;
            btnSil.ForeColor = SystemColors.ControlText;
            btnSil.Location = new Point(227, 31);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(140, 40);
            btnSil.TabIndex = 3;
            btnSil.Text = "Müşteri Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.SaddleBrown;
            btnGuncelle.ForeColor = SystemColors.ControlText;
            btnGuncelle.Location = new Point(43, 181);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(140, 40);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Müşteri Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnArama
            // 
            btnArama.BackColor = Color.Yellow;
            btnArama.ForeColor = SystemColors.ControlText;
            btnArama.Location = new Point(43, 106);
            btnArama.Name = "btnArama";
            btnArama.Size = new Size(140, 40);
            btnArama.TabIndex = 1;
            btnArama.Text = "Müşteri Ara";
            btnArama.UseVisualStyleBackColor = false;
            btnArama.Click += btnArama_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.YellowGreen;
            btnEkle.ForeColor = SystemColors.ControlText;
            btnEkle.Location = new Point(43, 31);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(140, 40);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Müşteri Ekleme";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(227, 181);
            button1.Name = "button1";
            button1.Size = new Size(140, 40);
            button1.TabIndex = 6;
            button1.Text = "Müşteri Aktifleştirme";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Yetkiliİslem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(673, 596);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Yetkiliİslem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yetkili İslemleri";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnOturumKapat;
        private Button btnListele;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnArama;
        private Button btnEkle;
        private Button button1;
    }
}