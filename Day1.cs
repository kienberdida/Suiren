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
    public partial class Day1 : Form
    {
        private string morningRoutine;
        private string nightRoutine;
        public Day1()
        {
            InitializeComponent();
            this.morningRoutine = morningRoutine;
            this.nightRoutine = nightRoutine;
        }

        private void Day1_Load(object sender, EventArgs e)
        {
            txtMorningRoutine.Text = morningRoutine;
            txtNightRoutine.Text = nightRoutine;
        }
    }
}
