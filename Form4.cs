using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SuirenMainForm
{
    public partial class Form4 : Form
    {
        private string currentUsername;
        public Form4(string username)
        {
            InitializeComponent();
            currentUsername = username;
            txtboxNewPassword.PasswordChar = '*';
            txtboxConfirmNewPassword.PasswordChar = '*';

        }

        private void backtoLogIn_Click(object sender, EventArgs e)
        {
            Login backtoLogin = new Login();
            backtoLogin.Show();
            this.Hide();
        }

        private void txtboxNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxConfirmNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string newPassword = txtboxNewPassword.Text;
            string confirmNewPassword = txtboxConfirmNewPassword.Text;

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmNewPassword))
            {
                MessageBox.Show("Please enter and confirm your new password.", "Password Reset Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("New password and Confirm New Password do not match.", "Password Reset Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Form1.userCredentials.ContainsKey(currentUsername))
            {
                Form1.userCredentials[currentUsername] = newPassword;
                MessageBox.Show("Password has been reset successfully!", "Password Reset Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error: User not found.", "Password Reset Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
