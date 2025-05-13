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
    public partial class SkincareGoals : Form
    {
        public static List<string> selectedSkincareGoals = new List<string>();
        public SkincareGoals()
        {
            InitializeComponent();
        }

        private void SkincareGoals_Load(object sender, EventArgs e)
        {
            
        }

        private void checkboxClearSkin_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxClearSkin);
        }

        private void checkboxGlowingSkin_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxGlowingSkin);
        }

        private void checkboxAcne_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxAcne);
        }

        private void checkboxSmoothTexture_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxSmoothTexture);
        }

        private void checkboxEvenTone_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxEvenTone);
        }

        private void checkboxAntiAging_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxAntiAging);
        }

        private void checkboxHydration_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxHydration);
        }
        private void ToggleSelection(CheckBox checkBox)
        {
            if (checkBox.Checked)
            {
                if (!selectedSkincareGoals.Contains(checkBox.Text))
                    selectedSkincareGoals.Add(checkBox.Text);
            }
            else
            {
                selectedSkincareGoals.Remove(checkBox.Text);
            }
        }
        private void Next_Click(object sender, EventArgs e)
        {
            SkinAllergies newForm = new SkinAllergies();
            newForm.Show();
            this.Hide();
    }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            SkinAllergies newForm = new SkinAllergies();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SkinConcerns newForm = new SkinConcerns();
            newForm.Show();
            this.Hide();
        }
    }
}