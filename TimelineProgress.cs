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
    public partial class TimelineProgress : Form
    {
        private string morningRoutine;
        private string nightRoutine;
        public TimelineProgress(string morningRoutine, string nightRoutine)
        {
            InitializeComponent();
            this.morningRoutine = morningRoutine;
            this.nightRoutine = nightRoutine;
        }

        private void TimelineProgress_Load(object sender, EventArgs e)
        {
            
        }

        private void Day1Btn_Click(object sender, EventArgs e)
        {

        }
        private void LoadFormInPanel(Form formToLoad)
        {
            centerPanel.Controls.Clear();
            formToLoad.TopLevel = false;
            formToLoad.FormBorderStyle = FormBorderStyle.None;
            formToLoad.Dock = DockStyle.Fill;
            centerPanel.Controls.Add(formToLoad);
            formToLoad.Show();
        }
    }
}
