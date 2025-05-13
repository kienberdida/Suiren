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
    public partial class SkinAllergies : Form
    {
        public static List<string> selectedSkinAllergies = new List<string>();
        public SkinAllergies()
        {
            InitializeComponent();
        }

        private void SkinAllergies_Load(object sender, EventArgs e)
        {

        }

        private void checkboxItching_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxItching);
        }

        private void checkboxRedness_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxRedness);
        }

        private void checkboxSwelling_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxSwelling);
        }

        private void checkboxHives_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxHives);
        }

        private void checkboxSunsensitivity_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxSunsensitivity);
        }

        private void checkboxBlisters_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxBlisters);
        }

        private void checkboxFlaky_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxFlaky);
        }
        private void ToggleSelection(CheckBox checkBox)
        {
            if (checkBox.Checked)
            {
                if (!selectedSkinAllergies.Contains(checkBox.Text))
                    selectedSkinAllergies.Add(checkBox.Text);
            }
            else
            {
                selectedSkinAllergies.Remove(checkBox.Text);
            }
        }
        private void Next_Click(object sender, EventArgs e)
        {
            LifestyleFactor newForm = new LifestyleFactor();
            newForm.Show();
            this.Hide();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            LifestyleFactor newForm = new LifestyleFactor();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SkincareGoals newForm = new SkincareGoals();
            newForm.Show();
            this.Hide();
        }
    }
}
