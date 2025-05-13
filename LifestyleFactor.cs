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

    public partial class LifestyleFactor : Form
    {
        public static string wearsMakeup = "";
        public static string climate = "";
        public static string hoursOfSleep = "";
        public static string worksOutdoors = "";
        public LifestyleFactor()
        {
            InitializeComponent();
        }

        private void LifestyleFactor_Load(object sender, EventArgs e)
        {

        }

        private void checkboxYes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxYes.Checked)
            {
                wearsMakeup = "Yes";
                checkboxNo.Checked = false;
            }
        }

        private void checkboxNo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxNo.Checked)
            {
                wearsMakeup = "No";
                checkboxYes.Checked = false;
            }
        }

        private void checkboxHotClimate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxHotClimate.Checked)
            {
                climate = "Hot Climate";
                checkboxColdClimate.Checked = false;
                checkboxDryClimate.Checked = false;
            }
        }

        private void checkboxColdClimate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxColdClimate.Checked)
            {
                climate = "Cold Climate";
                checkboxHotClimate.Checked = false;
                checkboxDryClimate.Checked = false;
            }
        }

        private void checkboxDryClimate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxDryClimate.Checked)
            {
                climate = "Dry Climate";
                checkboxHotClimate.Checked = false;
                checkboxColdClimate.Checked = false;
            }
        }

        private void textboxHours_TextChanged(object sender, EventArgs e)
        {
            hoursOfSleep = textboxHours.Text;
        }

        private void checkboxYes1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxYes1.Checked)
            {
                worksOutdoors = "Yes";
                checkboxNo1.Checked = false;
            }
        }

        private void checkboxNo1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxNo1.Checked)
            {
                worksOutdoors = "No";
                checkboxYes1.Checked = false;
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            string lifestyleSummary = $"Makeup: {wearsMakeup}, Climate: {climate}, Sleep: {hoursOfSleep} hrs, Outdoors: {worksOutdoors}";

            string skinType = string.Join(", ", SkinType.selectedSkinTypes);
            string skinTone = string.Join(", ", SkinTone.selectedSkinTones);
            string skinConcerns = string.Join(", ", SkinConcerns.selectedSkinConcerns);
            string skinAllergies = string.Join(", ", SkinAllergies.selectedSkinAllergies);
            string skincareGoals = string.Join(", ", SkincareGoals.selectedSkincareGoals);
            string userName = UserProfile.userName;
            string userAge = UserProfile.userAge;
            string userGender = UserProfile.userGender;
            string userBirthdate = UserProfile.userBirthdate;


            MainFrame mainFrame = new MainFrame(
                skinType,
                skinTone,
                skinConcerns,
                skinAllergies,
                skincareGoals,
                lifestyleSummary,
                userName,
                userAge,
                userGender,
                userBirthdate
            );


            mainFrame.Show();
            this.Hide();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            string lifestyleSummary = $"Makeup: {wearsMakeup}, Climate: {climate}, Sleep: {hoursOfSleep} hrs, Outdoors: {worksOutdoors}";

            string skinType = string.Join(", ", SkinType.selectedSkinTypes);
            string skinTone = string.Join(", ", SkinTone.selectedSkinTones);
            string skinConcerns = string.Join(", ", SkinConcerns.selectedSkinConcerns);
            string skinAllergies = string.Join(", ", SkinAllergies.selectedSkinAllergies);
            string skincareGoals = string.Join(", ", SkincareGoals.selectedSkincareGoals);

            string userName = UserProfile.userName;
            string userAge = UserProfile.userAge;
            string userGender = UserProfile.userGender;
            string userBirthdate = UserProfile.userBirthdate;

            MainFrame mainFrame = new MainFrame(
                skinType,
                skinTone,
                skinConcerns,
                skinAllergies,
                skincareGoals,
                lifestyleSummary,
                userName,
                userAge,
                userGender,
                userBirthdate
            );


            mainFrame.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SkinAllergies newForm = new SkinAllergies();
            newForm.Show();
            this.Hide();
        }
    }
}
