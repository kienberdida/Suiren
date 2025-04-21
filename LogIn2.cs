using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
    public partial class LogIn2 : Form
    {
        public LogIn2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0'; // Show password
            }
            else
            {
                textBox2.PasswordChar = '*'; // Mask password
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Check if username exists and if password matches
            if (Form1.userCredentials.ContainsKey(username) && Form1.userCredentials[username] == password)
            {
                MessageBox.Show("Login successful!");
                // Optionally, navigate to another form after login success
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 createAccountForm = new Form1();
            createAccountForm.Show();
            this.Hide(); // Hide the current form (LogIn2)
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 createAccountForm = new Form1();
            createAccountForm.Show();
            this.Hide(); // Hide the current form (LogIn2)
        }
    }
}
