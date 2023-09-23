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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yetkiliİslem));
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnPasiflestir = new Button();
            btnaktiflestir = new Button();
            btnOturumKapat = new Button();
            btnListele = new Button();
            btnGuncelle = new Button();
            btnArama = new Button();
            btnEkle = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(497, 43);
            label1.Name = "label1";
            label1.Size = new Size(472, 50);
            label1.TabIndex = 0;
            label1.Text = "Sayın Yetkili Admin Hoşgeldiniz";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(btnPasiflestir);
            groupBox1.Controls.Add(btnaktiflestir);
            groupBox1.Controls.Add(btnOturumKapat);
            groupBox1.Controls.Add(btnListele);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(btnArama);
            groupBox1.Controls.Add(btnEkle);
            groupBox1.Location = new Point(485, 177);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(550, 469);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnPasiflestir
            // 
            btnPasiflestir.BackColor = Color.ForestGreen;
            btnPasiflestir.Font = new Font("Segoe UI Historic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            btnPasiflestir.ForeColor = SystemColors.Control;
            btnPasiflestir.Image = (Image)resources.GetObject("btnPasiflestir.Image");
            btnPasiflestir.ImageAlign = ContentAlignment.BottomCenter;
            btnPasiflestir.Location = new Point(299, 299);
            btnPasiflestir.Margin = new Padding(3, 4, 3, 4);
            btnPasiflestir.Name = "btnPasiflestir";
            btnPasiflestir.Size = new Size(230, 77);
            btnPasiflestir.TabIndex = 7;
            btnPasiflestir.Text = "Müşteri Pasifleştirme";
            btnPasiflestir.UseVisualStyleBackColor = false;
            btnPasiflestir.Click += btnPasiflestir_Click;
            // 
            // btnaktiflestir
            // 
            btnaktiflestir.BackColor = Color.ForestGreen;
            btnaktiflestir.Font = new Font("Segoe UI Historic", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            btnaktiflestir.ForeColor = SystemColors.Control;
            btnaktiflestir.Image = (Image)resources.GetObject("btnaktiflestir.Image");
            btnaktiflestir.ImageAlign = ContentAlignment.BottomCenter;
            btnaktiflestir.Location = new Point(299, 177);
            btnaktiflestir.Margin = new Padding(3, 4, 3, 4);
            btnaktiflestir.Name = "btnaktiflestir";
            btnaktiflestir.Size = new Size(230, 77);
            btnaktiflestir.TabIndex = 6;
            btnaktiflestir.Text = "Müşteri Aktifleştirme";
            btnaktiflestir.UseVisualStyleBackColor = false;
            btnaktiflestir.Click += button1_Click;
            // 
            // btnOturumKapat
            // 
            btnOturumKapat.BackColor = Color.Gray;
            btnOturumKapat.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnOturumKapat.ForeColor = SystemColors.Control;
            btnOturumKapat.Location = new Point(131, 384);
            btnOturumKapat.Margin = new Padding(3, 4, 3, 4);
            btnOturumKapat.Name = "btnOturumKapat";
            btnOturumKapat.Size = new Size(287, 69);
            btnOturumKapat.TabIndex = 5;
            btnOturumKapat.Text = "Oturumu Sonlandır";
            btnOturumKapat.UseVisualStyleBackColor = false;
            btnOturumKapat.Click += btnOturumKapat_Click;
            // 
            // btnListele
            // 
            btnListele.BackColor = SystemColors.ControlDarkDark;
            btnListele.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnListele.ForeColor = SystemColors.Control;
            btnListele.Image = (Image)resources.GetObject("btnListele.Image");
            btnListele.ImageAlign = ContentAlignment.BottomCenter;
            btnListele.Location = new Point(299, 48);
            btnListele.Margin = new Padding(3, 4, 3, 4);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(230, 69);
            btnListele.TabIndex = 4;
            btnListele.Text = "Müşteri Listele";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.SaddleBrown;
            btnGuncelle.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuncelle.ForeColor = SystemColors.Control;
            btnGuncelle.Image = (Image)resources.GetObject("btnGuncelle.Image");
            btnGuncelle.ImageAlign = ContentAlignment.BottomCenter;
            btnGuncelle.Location = new Point(35, 307);
            btnGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(230, 69);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Müşteri Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnArama
            // 
            btnArama.BackColor = Color.Yellow;
            btnArama.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnArama.ForeColor = SystemColors.Control;
            btnArama.Image = (Image)resources.GetObject("btnArama.Image");
            btnArama.ImageAlign = ContentAlignment.BottomCenter;
            btnArama.Location = new Point(35, 177);
            btnArama.Margin = new Padding(3, 4, 3, 4);
            btnArama.Name = "btnArama";
            btnArama.Size = new Size(230, 69);
            btnArama.TabIndex = 1;
            btnArama.Text = "Müşteri Ara";
            btnArama.UseVisualStyleBackColor = false;
            btnArama.Click += btnArama_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.YellowGreen;
            btnEkle.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.ForeColor = SystemColors.Control;
            btnEkle.Image = (Image)resources.GetObject("btnEkle.Image");
            btnEkle.ImageAlign = ContentAlignment.BottomCenter;
            btnEkle.Location = new Point(35, 48);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(230, 69);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Müşteri Ekleme";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // Yetkiliİslem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1082, 703);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Yetkiliİslem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yetkili İslemleri";
            Load += Yetkiliİslem_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnOturumKapat;
        private Button btnListele;
        private Button btnGuncelle;
        private Button btnArama;
        private Button btnEkle;
        private Button btnaktiflestir;
        protected GroupBox groupBox1;
        private Button btnPasiflestir;
    }
}