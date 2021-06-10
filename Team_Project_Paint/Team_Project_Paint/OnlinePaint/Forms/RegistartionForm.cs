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
    public partial class RegistartionForm : Form
    {
        public RegistartionForm()
        {
            InitializeComponent();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            
            if (true) //TODO add condition
            {
                FormsManager.mainForm.Show();
                Hide();
            }
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            
            FormsManager.autorizationForm.Show();
            Hide();
        }

        private void RegistartionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormsManager.dummyForm.Close();
        }
    }
}
