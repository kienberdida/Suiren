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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // Set password character for the password textbox
            txtboxPassword.PasswordChar = '*';
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkboxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            txtboxPassword.PasswordChar = checkboxShowPassword.Checked ? '\0' : '*';
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = txtboxUsername.Text.Trim();
            string password = txtboxPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the entered credentials match the registered users
            if (Form1.userCredentials.ContainsKey(username) && Form1.userCredentials[username] == password)
            {
                MessageBox.Show("Login successful!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Optionally, you can navigate to another page here after successful login
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Clear the textboxes
            txtboxUsername.Clear();
            txtboxPassword.Clear();
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            // Create an instance of the registration form
            Form1 registerForm = new Form1();
            // Show the registration form
            registerForm.Show();
            // Hide the current login form
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
