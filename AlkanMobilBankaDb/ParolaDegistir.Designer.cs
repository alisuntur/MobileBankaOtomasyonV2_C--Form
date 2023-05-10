namespace AlkanMobilBankaDb
{
    partial class ParolaDegistir
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtback = new TextBox();
            txtnew = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(377, 143);
            button1.Name = "button1";
            button1.Size = new Size(150, 31);
            button1.TabIndex = 11;
            button1.Text = "Parola Değiştir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(143, 165);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 23);
            label2.TabIndex = 9;
            label2.Text = "Yeni Parola  :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(127, 57);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(454, 37);
            label1.TabIndex = 8;
            label1.Text = "Parola Değiştirme Ekranına Hoşgeldiniz ..";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(143, 127);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 12;
            label3.Text = "Eski Parola :";
            // 
            // txtback
            // 
            txtback.Location = new Point(249, 129);
            txtback.Name = "txtback";
            txtback.Size = new Size(100, 23);
            txtback.TabIndex = 13;
            // 
            // txtnew
            // 
            txtnew.Location = new Point(249, 171);
            txtnew.Name = "txtnew";
            txtnew.Size = new Size(100, 23);
            txtnew.TabIndex = 14;
            // 
            // ParolaDegistir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 485);
            Controls.Add(txtnew);
            Controls.Add(txtback);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ParolaDegistir";
            Text = "ParolaDegistir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtback;
        private TextBox txtnew;
    }
}