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
    public partial class Form1 : Form
    {
        public static Dictionary<string, string> userCredentials = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0'; // Show password
                textBox3.PasswordChar = '\0'; // Show confirm password
            }
            else
            {
                textBox2.PasswordChar = '*'; // Mask password
                textBox3.PasswordChar = '*'; // Mask confirm password
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string confirmPassword = textBox3.Text;

            // Check if the password and confirm password match
            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password must match.");
                return;
            }

            // Check if username and password are entered
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                // Save credentials in the static dictionary
                userCredentials[username] = password;
                MessageBox.Show("Account created successfully!");

                // Optionally, clear the textboxes after successful account creation
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); // Clear username
            textBox2.Clear(); // Clear password
            textBox3.Clear(); // Clear confirm password
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            LogIn2 loginForm = new LogIn2();
            loginForm.Show();
            this.Hide(); // Hide the current form (Form1)
        }
    }
}
