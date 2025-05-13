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
    public partial class Form3 : Form
    {
        private string skinType;
        private string skinTone;
        private string skinConcerns;
        private string skinAllergies;
        private string skincareGoals;
        private string lifestyleFactors;
        private string userName;
        private string userAge;
        private string userGender;
        private string userBirthdate;
        public Form3(
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
            this.skinType = skinType;
            this.skinTone = skinTone;
            this.skinConcerns = skinConcerns;
            this.skinAllergies = skinAllergies;
            this.skincareGoals = skincareGoals;
            this.lifestyleFactors = lifestyleFactors;
            this.userName = userName;
            this.userAge = userAge;
            this.userGender = userGender;
            this.userBirthdate = userBirthdate;
        }
        private void Form3_Load_1(object sender, EventArgs e)
        {
            informationTextBox.Text =
            "Name: " + userName + "\n" +
            "Age: " + userAge + "\n" +
            "Gender: " + userGender + "\n" +
            "Birthdate: " + userBirthdate;

            skinTypeTextBox.Text = "Skin Type: " + skinType;

            ToneTextBox.Text = "Skin Tone: " + skinTone;

            ConcernsTextBox.Text = "Concerns: " + skinConcerns;

            AllergiesTextBox.Text = "Allergies: " + skinAllergies;

            GoalsTextBox.Text = "Goals: " + skincareGoals;

            FactorsTextBox.Text = "Lifestyle: " + lifestyleFactors;

            informationTextBox.ReadOnly = true;
            skinTypeTextBox.ReadOnly = true;
            ToneTextBox.ReadOnly = true;
            ConcernsTextBox.ReadOnly = true;
            AllergiesTextBox.ReadOnly = true;
            GoalsTextBox.ReadOnly = true;
            FactorsTextBox.ReadOnly = true;

        }
        private void createroutineBtn_Click(object sender, EventArgs e)
        {
            MyRoutine routineForm = new MyRoutine(skinType, skinTone, skinConcerns, skincareGoals);
            routineForm.TopLevel = false;
            routineForm.FormBorderStyle = FormBorderStyle.None;
            routineForm.Dock = DockStyle.Fill;

            Control parentPanel = this.Parent;
            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(routineForm);
            routineForm.Show();
        }

        private void EditTypeBtn_Click(object sender, EventArgs e)
        {
            SkinType nextForm = new SkinType();
            nextForm.Show();
            this.Hide();
        }

        private void EditToneBtn_Click(object sender, EventArgs e)
        {
            SkinTone nextForm = new SkinTone();
            nextForm.Show();
            this.Hide();
        }

        private void EditConcernsBtn_Click(object sender, EventArgs e)
        {
            SkinConcerns nextForm = new SkinConcerns();
            nextForm.Show();
            this.Hide();
        }

        private void EditAllergiesBtn_Click(object sender, EventArgs e)
        {
            SkinAllergies newForm = new SkinAllergies();
            newForm.Show();
            this.Hide();
        }

        private void EditGoalsBtn_Click(object sender, EventArgs e)
        {
            SkincareGoals newForm = new SkincareGoals();
            newForm.Show();
            this.Hide();
        }

        private void EditFactorsBtn_Click(object sender, EventArgs e)
        {
            LifestyleFactor newForm = new LifestyleFactor();
            newForm.Show();
            this.Hide();
        }

        private void EditDetailsBtn_Click(object sender, EventArgs e)
        {
            UserProfile userprofile = new UserProfile();
            userprofile.Show();
            this.Hide();
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Your custom painting code
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle text change logic
        }

        private void GoalsTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle goals text change
        }

        private void AllergiesTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle allergies input
        }

        private void skinTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle skin type input
        }

        private void ToneTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle tone input
        }

        private void ConcernsTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle skin concerns input
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Optional: custom painting code for panel2
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Optional: custom painting code for panel3
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            // Optional: custom painting code for panel4
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            // Optional: custom painting code for panel6
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            // Optional: custom painting code for panel7
        }

    }
}
