namespace AlkanMobilBankaDb
{
    partial class ParaCek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaCek));
            label1 = new Label();
            label2 = new Label();
            txtTutar = new MaskedTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(475, 44);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(483, 47);
            label1.TabIndex = 0;
            label1.Text = "Para Çekme Ekranına Hoşgeldiniz";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(260, 260);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(321, 76);
            label2.TabIndex = 1;
            label2.Text = "Hesabınızdan Çekmek \r\nİstediğiniz Tutar (TL) :";
            label2.Click += label2_Click;
            // 
            // txtTutar
            // 
            txtTutar.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtTutar.Location = new Point(301, 360);
            txtTutar.Mask = "00000000000000000000000000000000";
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(233, 36);
            txtTutar.TabIndex = 2;
            txtTutar.ValidatingType = typeof(int);
            txtTutar.MaskInputRejected += txtTutar_MaskInputRejected;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.BottomLeft;
            button1.Location = new Point(338, 430);
            button1.Name = "button1";
            button1.Size = new Size(154, 46);
            button1.TabIndex = 3;
            button1.Text = "Para Çek";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ParaCek
            // 
            AutoScaleDimensions = new SizeF(17F, 46F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1082, 703);
            Controls.Add(button1);
            Controls.Add(txtTutar);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(6, 7, 6, 7);
            Name = "ParaCek";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParaCek";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox txtTutar;
        private Button button1;
    }
}