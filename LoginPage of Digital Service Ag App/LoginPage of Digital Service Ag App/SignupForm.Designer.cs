namespace LoginPage_of_Digital_Service_Ag_App
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            fullnametextBox = new TextBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            usernametextBox = new TextBox();
            label5 = new Label();
            PasswordtextBox = new TextBox();
            label6 = new Label();
            ConfPasstextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            EmailtextBox = new TextBox();
            PNtextBox = new TextBox();
            SignUPbutton = new Button();
            Cancelbutton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 27);
            label1.Name = "label1";
            label1.Size = new Size(551, 38);
            label1.TabIndex = 0;
            label1.Text = "Sign Up for SAMDIG TECH Agency";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 65);
            label2.Name = "label2";
            label2.Size = new Size(696, 25);
            label2.TabIndex = 1;
            label2.Text = "–––––––––––––––––––––––––––––––––––––––––––––––––––––––––";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(PNtextBox);
            panel1.Controls.Add(EmailtextBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(ConfPasstextBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(PasswordtextBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(usernametextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(fullnametextBox);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(250, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(561, 373);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(16, 21);
            label3.Name = "label3";
            label3.Size = new Size(147, 35);
            label3.TabIndex = 0;
            label3.Text = "Full Name";
            label3.Click += label3_Click;
            // 
            // fullnametextBox
            // 
            fullnametextBox.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fullnametextBox.Location = new Point(274, 14);
            fullnametextBox.Name = "fullnametextBox";
            fullnametextBox.Size = new Size(264, 42);
            fullnametextBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(16, 81);
            label4.Name = "label4";
            label4.Size = new Size(154, 35);
            label4.TabIndex = 2;
            label4.Text = "User Name";
            // 
            // usernametextBox
            // 
            usernametextBox.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernametextBox.Location = new Point(274, 78);
            usernametextBox.Name = "usernametextBox";
            usernametextBox.Size = new Size(264, 42);
            usernametextBox.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(16, 147);
            label5.Name = "label5";
            label5.Size = new Size(137, 35);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordtextBox.Location = new Point(274, 144);
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.Size = new Size(264, 42);
            PasswordtextBox.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Desktop;
            label6.Location = new Point(16, 202);
            label6.Name = "label6";
            label6.Size = new Size(252, 35);
            label6.TabIndex = 6;
            label6.Text = "Confirm Password";
            label6.Click += label6_Click;
            // 
            // ConfPasstextBox
            // 
            ConfPasstextBox.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfPasstextBox.Location = new Point(274, 199);
            ConfPasstextBox.Name = "ConfPasstextBox";
            ConfPasstextBox.Size = new Size(264, 42);
            ConfPasstextBox.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Desktop;
            label7.Location = new Point(16, 258);
            label7.Name = "label7";
            label7.Size = new Size(131, 35);
            label7.TabIndex = 8;
            label7.Text = "Email ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Desktop;
            label8.Location = new Point(16, 307);
            label8.Name = "label8";
            label8.Size = new Size(206, 35);
            label8.TabIndex = 9;
            label8.Text = "Phone Number";
            label8.Click += label8_Click;
            // 
            // EmailtextBox
            // 
            EmailtextBox.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailtextBox.Location = new Point(274, 255);
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(264, 42);
            EmailtextBox.TabIndex = 10;
            // 
            // PNtextBox
            // 
            PNtextBox.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PNtextBox.Location = new Point(274, 312);
            PNtextBox.Name = "PNtextBox";
            PNtextBox.Size = new Size(264, 42);
            PNtextBox.TabIndex = 11;
            // 
            // SignUPbutton
            // 
            SignUPbutton.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUPbutton.Location = new Point(336, 500);
            SignUPbutton.Name = "SignUPbutton";
            SignUPbutton.Size = new Size(182, 52);
            SignUPbutton.TabIndex = 4;
            SignUPbutton.Text = "Sign Up";
            SignUPbutton.UseVisualStyleBackColor = true;
            SignUPbutton.Click += button1_Click;
            // 
            // Cancelbutton
            // 
            Cancelbutton.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancelbutton.Location = new Point(580, 501);
            Cancelbutton.Name = "Cancelbutton";
            Cancelbutton.Size = new Size(149, 50);
            Cancelbutton.TabIndex = 5;
            Cancelbutton.Text = "Cancel";
            Cancelbutton.UseVisualStyleBackColor = true;
            Cancelbutton.Click += button2_Click;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(823, 613);
            Controls.Add(Cancelbutton);
            Controls.Add(SignUPbutton);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.HotTrack;
            Margin = new Padding(5, 4, 5, 4);
            Name = "SignupForm";
            Text = "SignupForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private TextBox fullnametextBox;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox usernametextBox;
        private Label label4;
        private Label label6;
        private TextBox PasswordtextBox;
        private Label label5;
        private TextBox ConfPasstextBox;
        private TextBox PNtextBox;
        private TextBox EmailtextBox;
        private Label label8;
        private Label label7;
        private Button SignUPbutton;
        private Button Cancelbutton;
    }
}