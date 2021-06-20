using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Project_Paint
{
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {

            FormsManager.mainForm.Show();
            Hide();
        }

        private void StatsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormsManager.mainForm.Show();
            Hide();
        }
    }
}
