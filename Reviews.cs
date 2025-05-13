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
    public partial class CustomerReviews : Form
    {
        public CustomerReviews()
        {
            InitializeComponent();
        }

        private void CustomerReviews_Load(object sender, EventArgs e)
        {
            RatingPictureBox.Image = Image.FromFile(@"C:\Users\Administrator\Downloads\Ratings1.jpg");
            RatingPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            RatingPictureBox2.Image = Image.FromFile(@"C:\Users\Administrator\Downloads\Ratings2.jpg");
            RatingPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void RatingPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string feedback = button1.Text;

            if (!string.IsNullOrWhiteSpace(feedback))
            {
                MessageBox.Show("Thank you for your feedback!", "Feedback Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox5.Clear(); 
            }
            else
            {
                MessageBox.Show("Please enter your feedback before sending.", "Empty Feedback", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
