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
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }
        public static string userName = "";
        public static string userAge = "";
        public static string userGender = "";
        public static string userBirthdate = "";
        private void textboxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxBirthdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            UserProfile.userName = textboxName.Text;
            UserProfile.userAge = textboxAge.Text;
            UserProfile.userGender = textboxGender.Text;
            UserProfile.userBirthdate = textboxBirthdate.Text;

            SkinType skinTypeForm = new SkinType();
            skinTypeForm.Show();
            this.Hide();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void UploadImage_Click(object sender, EventArgs e)
        {
            
        }

        private void nextBtn_Click_1(object sender, EventArgs e)
        {
            UserProfile.userName = textboxName.Text;
            UserProfile.userAge = textboxAge.Text;
            UserProfile.userGender = textboxGender.Text;
            UserProfile.userBirthdate = textboxBirthdate.Text;

            SkinType skinTypeForm = new SkinType();
            skinTypeForm.Show();
            this.Hide();
        }
    }
}

