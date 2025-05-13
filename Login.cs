using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuirenMainForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtboxPassword.PasswordChar = '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void checkboxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
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

            if (Form1.userCredentials.ContainsKey(username) && Form1.userCredentials[username] == password)
            {
                MessageBox.Show("Login successful!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStarted getStarted = new GetStarted();
                getStarted.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            txtboxUsername.Clear();
            txtboxPassword.Clear();

        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            Form1 registerForm = new Form1();
            registerForm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();
        }

        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            Form1 registerForm = new Form1();
            registerForm.Show();
            this.Hide();
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
