namespace AlkanMobilBankaDb
{
    partial class AnaEkran
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            groupBox1 = new GroupBox();
            button1 = new Button();
            radioButton1 = new RadioButton();
            label3 = new Label();
            radioButton2 = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(86, 207);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(561, 330);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.InactiveCaptionText;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(195, 221);
            button1.Name = "button1";
            button1.Size = new Size(245, 43);
            button1.TabIndex = 7;
            button1.Text = "DEVAM";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(334, 165);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(106, 34);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Personel";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 168);
            label3.Name = "label3";
            label3.Size = new Size(137, 30);
            label3.TabIndex = 6;
            label3.Text = "Giriş Seçeneği:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(195, 164);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(98, 34);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Müşteri";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 116);
            label2.Name = "label2";
            label2.Size = new Size(81, 30);
            label2.TabIndex = 3;
            label2.Text = "Parola :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 62);
            label1.Name = "label1";
            label1.Size = new Size(134, 30);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı :";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(195, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 36);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(195, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 36);
            textBox1.TabIndex = 0;
            // 
            // AnaEkran
            // 
            AutoScaleDimensions = new SizeF(10F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1129, 703);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AnaEkran";
            Text = "Form1";
            Load += AnaEkran_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
    }
}