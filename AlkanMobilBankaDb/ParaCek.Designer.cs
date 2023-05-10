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
            label1 = new Label();
            label2 = new Label();
            txtTutar = new MaskedTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 71);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(392, 37);
            label1.TabIndex = 0;
            label1.Text = "Para Çekme Ekranına Hoşgeldiniz ..";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(85, 146);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(310, 23);
            label2.TabIndex = 1;
            label2.Text = "Hesabınızdan Çekmek İstediğiniz Tutar (TL) :";
            label2.Click += label2_Click;
            // 
            // txtTutar
            // 
            txtTutar.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtTutar.Location = new Point(404, 143);
            txtTutar.Mask = "0000000000";
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(64, 30);
            txtTutar.TabIndex = 2;
            txtTutar.ValidatingType = typeof(int);
            txtTutar.MaskInputRejected += txtTutar_MaskInputRejected;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(290, 202);
            button1.Name = "button1";
            button1.Size = new Size(105, 34);
            button1.TabIndex = 3;
            button1.Text = "Para Çek";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ParaCek
            // 
            AutoScaleDimensions = new SizeF(13F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 456);
            Controls.Add(button1);
            Controls.Add(txtTutar);
            Controls.Add(label2);
            Controls.Add(label1);
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