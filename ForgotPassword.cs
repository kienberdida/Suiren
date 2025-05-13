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
    public partial class ForgotPassword : Form
    {
        private string generatedCode = "123456";
        private string associatedUsername;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            string enteredEmail = textBox1.Text.Trim();
            bool emailFound = false;
            associatedUsername = null;

            foreach (var pair in Form1.userEmails)
            {
                if (pair.Value.Equals(enteredEmail, StringComparison.OrdinalIgnoreCase))
                {
                    emailFound = true;
                    associatedUsername = pair.Key; 
                    break;
                }
            }

            if (emailFound)
            {
                MessageBox.Show("Code has been sent to the email.", "Verification Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The entered email was not found.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            string enteredCode = textBox2.Text;

            if (enteredCode == generatedCode)
            {
                Form4 setNewPasswordForm = new Form4(associatedUsername);
                setNewPasswordForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect code. Please try again.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login Backtologin = new Login();
            Backtologin.Show();
            this.Hide();
        }
    }
}
