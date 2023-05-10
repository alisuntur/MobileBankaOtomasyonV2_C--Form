namespace AlkanMobilBankaDb
{
    partial class ParaYatir
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
            txtTutarYatan = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(486, 194);
            button1.Name = "button1";
            button1.Size = new Size(105, 34);
            button1.TabIndex = 7;
            button1.Text = "Para Yatır";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtTutarYatan
            // 
            txtTutarYatan.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtTutarYatan.Location = new Point(515, 142);
            txtTutarYatan.Mask = "0000000000";
            txtTutarYatan.Name = "txtTutarYatan";
            txtTutarYatan.Size = new Size(64, 30);
            txtTutarYatan.TabIndex = 6;
            txtTutarYatan.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(196, 145);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(303, 23);
            label2.TabIndex = 5;
            label2.Text = "Hesabınıza Yatırmak İstediğiniz Tutar (TL) :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(196, 70);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(408, 37);
            label1.TabIndex = 4;
            label1.Text = "Para Yatırma Ekranına Hoşgeldiniz ..";
            // 
            // ParaYatir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtTutarYatan);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ParaYatir";
            Text = "ParaYatir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MaskedTextBox txtTutarYatan;
        private Label label2;
        private Label label1;
    }
}