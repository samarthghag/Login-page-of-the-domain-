namespace LoginPage_of_Digital_Service_Ag_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 22);
            label1.Name = "label1";
            label1.Size = new Size(0, 35);
            label1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(404, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(463, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 400);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(423, 268);
            button2.Name = "button2";
            button2.Size = new Size(192, 53);
            button2.TabIndex = 8;
            button2.Text = "SIGN-UP";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(62, 267);
            button1.Name = "button1";
            button1.Size = new Size(214, 54);
            button1.TabIndex = 7;
            button1.Text = "LOGIN-IN  ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(359, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(318, 53);
            textBox2.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 181);
            label6.Name = "label6";
            label6.Size = new Size(244, 45);
            label6.TabIndex = 5;
            label6.Text = "PASSWORD";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(359, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 53);
            textBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 97);
            label5.Name = "label5";
            label5.Size = new Size(260, 45);
            label5.TabIndex = 3;
            label5.Text = "USER NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Indigo;
            label4.Location = new Point(18, 59);
            label4.Name = "label4";
            label4.Size = new Size(675, 23);
            label4.TabIndex = 2;
            label4.Text = "-----------------------------------------------------------------------------------------------";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(292, 14);
            label3.Name = "label3";
            label3.Size = new Size(164, 45);
            label3.TabIndex = 1;
            label3.Text = "LOGIN ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(260, 18);
            label2.Name = "label2";
            label2.Size = new Size(659, 51);
            label2.TabIndex = 3;
            label2.Text = "WELCOME TO SAMDIG TECH";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1200, 518);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            Name = "Form1";
            Text = "Login Form App";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
    }
}
