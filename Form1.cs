using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SuirenMainForm
{
    public partial class Form1 : Form
    {
        public static Dictionary<string, string> userCredentials = new Dictionary<string, string>();
        public static Dictionary<string, string> userEmails = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            txtboxPassword.PasswordChar = '*';
            txtboxConfirmPassword.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkboxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtboxPassword.PasswordChar = checkboxShowPassword.Checked ? '\0' : '*';
            txtboxConfirmPassword.PasswordChar = checkboxShowPassword.Checked ? '\0' : '*';
        }

        private void RegisterBtn_Click(object sender, EventArgs e)

        {
            string username = txtboxUsername.Text.Trim();
            string password = txtboxPassword.Text;
            string confirmPassword = txtboxConfirmPassword.Text;
            string email = txtboxEmail.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all the fields.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (userCredentials.ContainsKey(username))
            {
                MessageBox.Show("Username already exists. Please choose a different one.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            userCredentials.Add(username, password);
            userEmails.Add(username, email);
            MessageBox.Show("Successfully created an account!", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtboxUsername.Clear();
            txtboxPassword.Clear();
            txtboxConfirmPassword.Clear();
            txtboxEmail.Clear();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtboxUsername.Clear();
            txtboxPassword.Clear();
            txtboxConfirmPassword.Clear();
            txtboxEmail.Clear();
        }

        private void backtoLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void txtboxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPass = new ForgotPassword();
            forgotPass.Show();
            this.Hide();
        }
    }
}
