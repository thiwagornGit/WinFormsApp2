namespace WinFormsApp2
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(518, 210);
            button1.Name = "button1";
            button1.Size = new Size(223, 61);
            button1.TabIndex = 0;
            button1.Text = "ปิดโปรแกรม";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(722, 114);
            button2.Name = "button2";
            button2.Size = new Size(94, 67);
            button2.TabIndex = 1;
            button2.Text = "เปิดไฟ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.MouseLeave += button2_MouseLeave;
            button2.MouseHover += button2_MouseHover;
            // 
            // button3
            // 
            button3.Location = new Point(466, 114);
            button3.Name = "button3";
            button3.Size = new Size(94, 67);
            button3.TabIndex = 2;
            button3.Text = "ปิดไฟ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            button3.MouseLeave += button3_MouseLeave;
            button3.MouseHover += button3_MouseHover;
            // 
            // label2
            // 
            label2.BackColor = Color.Yellow;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(437, 9);
            label2.Name = "label2";
            label2.Size = new Size(396, 102);
            label2.TabIndex = 4;
            label2.Text = "มหาวิทยาลัยราชภัฎอุดรธานี";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            label2.MouseLeave += label2_MouseLeave;
            label2.MouseHover += label2_MouseHover;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(409, 308);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(451, 27);
            textBox1.TabIndex = 5;
            textBox1.Text = "HI ";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.DoubleClick += textBox1_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1356, 529);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "WindowForm Control";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Click += Form1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private TextBox textBox1;
    }
}
