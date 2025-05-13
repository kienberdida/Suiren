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
    public partial class SkinType : Form
    {
        public static List<string> selectedSkinTypes = new List<string>();
        public SkinType()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkBox1);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkBox2);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkBox3);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkBox4);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkBox5);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            ToggleSelection(checkBox6);
        }

        private void ToggleSelection(CheckBox checkBox)
        {
            if (checkBox.Checked)
            {
                if (!selectedSkinTypes.Contains(checkBox.Text))
                    selectedSkinTypes.Add(checkBox.Text);
            }
            else
            {
                selectedSkinTypes.Remove(checkBox.Text);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SkinTone nextForm = new SkinTone();
            nextForm.Show();
            this.Hide();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            SkinTone nextForm = new SkinTone();
            nextForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SkinType_Load(object sender, EventArgs e)
        {

        }

        private void nextBtn_Click_1(object sender, EventArgs e)
        {
            SkinTone nextForm = new SkinTone();
            nextForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
