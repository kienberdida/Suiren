using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public static Dictionary<string, string> userCredentials = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            // Set password character for password and confirm password textboxes
            txtboxPassword.PasswordChar = '*';
            txtboxConfirmPassword.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtboxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtboxConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkboxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility for both password and confirm password fields
            txtboxPassword.PasswordChar = checkboxShowPassword.Checked ? '\0' : '*';
            txtboxConfirmPassword.PasswordChar = checkboxShowPassword.Checked ? '\0' : '*';
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string username = txtboxUsername.Text.Trim();
            string password = txtboxPassword.Text;
            string confirmPassword = txtboxConfirmPassword.Text;

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

            // Add the new user to the dictionary
            userCredentials.Add(username, password);
            MessageBox.Show("Successfully created an account!", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the textboxes after successful registration
            txtboxUsername.Clear();
            txtboxPassword.Clear();
            txtboxConfirmPassword.Clear();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            txtboxUsername.Clear();
            txtboxPassword.Clear();
            txtboxConfirmPassword.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void backtoLogin_Click(object sender, EventArgs e)
        {
            // Create an instance of the login form
            Form2 loginForm = new Form2();
            // Show the login form
            loginForm.Show();
            // Hide the current registration form
            this.Hide();
        }

    }
}
