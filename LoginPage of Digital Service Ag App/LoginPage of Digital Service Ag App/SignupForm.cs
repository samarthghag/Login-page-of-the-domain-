using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage_of_Digital_Service_Ag_App
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieving user input from text fields
            string fullName = fullnametextBox.Text.Trim();
            string username = usernametextBox.Text.Trim();
            string password = PasswordtextBox.Text.Trim();
            string confirmPassword = ConfPasstextBox.Text.Trim();
            string email = EmailtextBox.Text.Trim();
            string phoneNumber = PNtextBox.Text.Trim();

            // Validation
            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) ||
                string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill all mandatory fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Invalid Email Address!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Saving data to a file (or you can use a database)
            try
            {
                using (StreamWriter sw = new StreamWriter("users.txt", true))
                {
                    sw.WriteLine($"{fullName},{username},{password},{email},{phoneNumber}");
                }
                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form after successful signup
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            fullnametextBox.Clear();
            usernametextBox.Clear();
            PasswordtextBox.Clear();
            ConfPasstextBox.Clear();
            EmailtextBox.Clear();
            PNtextBox.Clear();

            // Optionally, close the form to go back to the previous one
            this.Close();
        }
    }
}
