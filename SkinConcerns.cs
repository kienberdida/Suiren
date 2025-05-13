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
    public partial class SkinConcerns : Form
    {
        public static List<string> selectedSkinConcerns = new List<string>();
        public SkinConcerns()
        {
            InitializeComponent();
        }

        private void SkinConcerns_Load(object sender, EventArgs e)
        {
            
        }

        private void checkboxAcnePimples_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxAcnePimples);
        }

        private void checkboxDarkSpots_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxDarkSpots);
        }

        private void checkboxDarkPatches_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxDarkPatches);
        }

        private void checkboxWrinkles_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxWrinkles);
        }

        private void checkboxOiliness_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxOiliness);
        }

        private void checkboxLargePores_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxLargePores);
        }

        private void checkboxUneven_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxUneven);
        }

        private void x_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(x);
        }
        private void ToggleSelection(CheckBox checkBox)
        {
            if (checkBox.Checked)
            {
                if (!selectedSkinConcerns.Contains(checkBox.Text))
                    selectedSkinConcerns.Add(checkBox.Text);
            }
            else
            {
                selectedSkinConcerns.Remove(checkBox.Text);
            }
        }
        public static string selectedSkinConcernsString = "";
        private void label2_Click(object sender, EventArgs e)
        {
            SkincareGoals newForm = new SkincareGoals();
            newForm.Show();
            this.Hide();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            SkincareGoals newForm = new SkincareGoals();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SkinTone newForm = new SkinTone();
            newForm.Show();
            this.Hide();
        }
    }
}
