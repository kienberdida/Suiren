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
    public partial class SkinTone : Form
    {
        public static List<string> selectedSkinTones = new List<string>();
        public SkinTone()
        {
            InitializeComponent();
        }

        private void SkinTone_Load(object sender, EventArgs e)
        {

        }

        private void checkboxFair_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxFair);
        }

        private void checkboxLight_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxLight);
        }

        private void checkboxMedium_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxMedium);
        }

        private void checkboxTan_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxTan);
        }

        private void checkboxDeep_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxDeep);
        }

        private void checkboxDark_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkboxDark);
        }

        private void ToggleSelection(CheckBox checkBox)
        {
            if (checkBox.Checked)
            {
                if (!selectedSkinTones.Contains(checkBox.Text))
                    selectedSkinTones.Add(checkBox.Text);
            }
            else
            {
                selectedSkinTones.Remove(checkBox.Text);
            }
        }
        public static string selectedSkinTypesString = "";

        private void label2_Click(object sender, EventArgs e)
        {
            SkinConcerns nextForm = new SkinConcerns();
            nextForm.Show();
            this.Hide();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            SkinConcerns nextForm = new SkinConcerns(); 
            nextForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SkinType nextForm = new SkinType();
            nextForm.Show();
            this.Hide();
        }
    }
}
