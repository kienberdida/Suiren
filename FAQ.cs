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
    public partial class FAQ : Form
    {
        public FAQ()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your skincare routine is personalized based on your skin type, tone, concerns, allergies, goals, and lifestyle factors. The app analyzes this information to recommend products and steps tailored to your unique skin needs.", "How is my skincare routine generated?");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can focus on the essential steps like cleansing, moisturizing, and sun protection. The app marks essential and optional steps to help you prioritize.", "What if I don’t have time for all steps in the routine?");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yes, your data is stored securely within the application. It’s used solely to personalize your experience and is not shared with third parties.", "Is my data safe?");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently, product suggestions are based on your skin profile. Budget filters may be added in future updates.", "Can I get product recommendations based on budget?");
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("When you mark a day as complete, the app gives you motivational messages and stores your progress so you can see how consistent you've been.", "What happens when I check off a day in my 7-day tracker?");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In the routine section, each product has a 'More Info' button. Click it to view details like ingredients, how to use, and its benefits.", "Where can I find more information about the products in my routine?");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you experience irritation, discontinue the product immediately. The app allows you to update your allergies and preferences, so we can adjust your routine accordingly.", "What if I have a skin reaction to a recommended product?");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Consistency is key! You should follow the morning and evening routines daily. The app also tracks your 7-day progress to help you stay on track.", "How often should I follow my skincare routine?");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yes, you can update your profile information like skin type, concerns, and goals anytime by going to the 'Your Profile' section in the app.", "Can I change my profile information after setup?");
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("While consistency delivers the best results, occasional skips are okay. The tracker helps you stay motivated and get back on track easily.", "Can I skip days and still see results?");
        }
    }
}
