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
    public partial class Home : Form
    {
        private MainFrame mainFrame;
        private string skinType, skinTone, skinConcerns, skincareGoals;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        public Home(MainFrame mainFrame, string skinType, string skinTone, string skinConcerns, string skincareGoals)
        {
            InitializeComponent();

            this.mainFrame = mainFrame;
            this.skinType = skinType;
            this.skinTone = skinTone;
            this.skinConcerns = skinConcerns;
            this.skincareGoals = skincareGoals;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyRoutine routine = new MyRoutine(skinType, skinTone, skinConcerns, skincareGoals);
            mainFrame.LoadFormInPanel(routine);
        }
    }
}
