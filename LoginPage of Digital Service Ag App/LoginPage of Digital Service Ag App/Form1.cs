namespace LoginPage_of_Digital_Service_Ag_App
{
    public partial class Form1 : Form
    {
        private object txtUsername;

        public Form1()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "Samarth Ghag"; // Hardcoded username
            string password = "samarth1504";  // Hardcoded password

            // Retrieve user input
            string enteredUsername = textBox1.Text.Trim();
            string enteredPassword = textBox2.Text.Trim();

            // Validation: Check if fields are empty
            if (string.IsNullOrEmpty(enteredUsername) || string.IsNullOrEmpty(enteredPassword))
            {
                MessageBox.Show("Please fill in both Username and Password fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Authentication logic
            if (enteredUsername == username && enteredPassword == password)
            {
                MessageBox.Show("Login Successful! Welcome to the Digital Service Agency.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Optional: Redirect to another form (e.g., Dashboard)
                //DashboardForm dashboard = new DashboardForm();
                //dashboard.Show();
                //this.Hide(); // Hide the login form
            }
            else
            {
                MessageBox.Show("Invalid Username or Password. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Redirect to the Sign-up form (optional)
            SignupForm signup = new SignupForm();
            signup.Show();
        }
    }
}
