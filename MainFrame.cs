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
    public partial class MainFrame : Form
    {
        private MainFrame _mainFrame; // To hold reference to MainFrame
        private string _skinType, _skinTone, _skinConcerns, _skincareGoals;

        // Constructor that accepts parameters
        
        private string skinType, skinTone, skinConcerns, skincareGoals;
        public MainFrame(
        string skinType,
        string skinTone,
        string skinConcerns,
        string skinAllergies,
        string skincareGoals,
        string lifestyleFactors,
        string userName,
        string userAge,
        string userGender,
        string userBirthdate)
        {
            InitializeComponent();
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;
            button7.Click += button7_Click;
            button8.Click += button8_Click;
            // Load Form3 inside panel2 when MainFrame opens
            DisplayForm3(
                skinType,
                skinTone,
                skinConcerns,
                skinAllergies,
                skincareGoals,
                lifestyleFactors,
                userName,
                userAge,
                userGender,
                userBirthdate
            );
        }

        private void DisplayForm3(
            string skinType,
            string skinTone,
            string skinConcerns,
            string skinAllergies,
            string skincareGoals,
            string lifestyleFactors,
            string userName,
            string userAge,
            string userGender,
            string userBirthdate)
        {
            Form3 form3 = new Form3(
                skinType,
                skinTone,
                skinConcerns,
                skinAllergies,
                skincareGoals,
                lifestyleFactors,
                userName,
                userAge,
                userGender,
                userBirthdate
            );

            form3.TopLevel = false;
            form3.FormBorderStyle = FormBorderStyle.None;
            form3.Dock = DockStyle.Fill;

            panel3.Controls.Clear();
            panel3.Controls.Add(form3);
            form3.Show();
        }
        public void LoadFormInPanel(Form formToLoad)
        {
            panel3.Controls.Clear(); // Use panel3 as your display panel

            formToLoad.TopLevel = false;
            formToLoad.FormBorderStyle = FormBorderStyle.None;
            formToLoad.Dock = DockStyle.Fill;

            panel3.Controls.Add(formToLoad);
            formToLoad.Show();
        }
        private void LoadForm(Form form)
        {
            panel3.Controls.Clear(); // ✅ use panel3

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel3.Controls.Add(form); // ✅ use panel3
            form.Show();
        }
        private void AllProducts_Click(object sender, EventArgs e)
        {
            AllProducts allProductsForm = new AllProducts();
            LoadFormInPanel(allProductsForm);
        }

        private void CustomerReviews_Click(object sender, EventArgs e)
        {
            CustomerReviews reviewsForm = new CustomerReviews();
            LoadFormInPanel(reviewsForm);
        }

        private void RecommendedProducts_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ChatSupport chatForm = new ChatSupport();
            LoadFormInPanel(chatForm);
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            

        }

        private void YourProfile_Click(object sender, EventArgs e)
        {
            FAQ faqForm = new FAQ(); 
            LoadFormInPanel(faqForm);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home(this, skinType, skinTone, skinConcerns, skincareGoals);
            LoadFormInPanel(homeForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AllProducts allProductsForm = new AllProducts();
            LoadFormInPanel(allProductsForm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            LoadFormInPanel(aboutUs); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CustomerReviews reviewsForm = new CustomerReviews();
            LoadFormInPanel(reviewsForm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FAQ faqForm = new FAQ();
            LoadFormInPanel(faqForm);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChatSupport chatForm = new ChatSupport();
            LoadFormInPanel(chatForm);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Close(); // Close MainFrame
            }   
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Close(); 
            }
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            LoadFormInPanel(aboutUs);
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home(this, skinType, skinTone, skinConcerns, skincareGoals);
            LoadFormInPanel(homeForm);
        }
        private void panel3_Paint(object sender, PaintEventArgs e) { }

        private void richTextBox1_TextChanged(object sender, EventArgs e) { }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GoalsTextBox_TextChanged(object sender, EventArgs e) { }

        private void AllergiesTextBox_TextChanged(object sender, EventArgs e) { }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void skinTypeTextBox_TextChanged(object sender, EventArgs e) { }

        private void ToneTextBox_TextChanged(object sender, EventArgs e) { }

        private void ConcernsTextBox_TextChanged(object sender, EventArgs e) { }

    }
}
