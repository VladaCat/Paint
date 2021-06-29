using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team_Project_Paint.Net;

namespace Team_Project_Paint
{
    public partial class AutorizationForm : Form
    {
        private bool _isEmail = false;
        private bool _isPass = false;
        public AutorizationForm()
        {
            InitializeComponent();
            txtServerUrl_TextChanged(null, null);
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {

            BoolStringType authResult = null;
            //TODO add validation. If successful - create request
            var userAutorizationData = new UserAutorizationData()
            {
                Login = txtLogin.Text,
                Password=txtPassword.Text
            };
            authResult= StaticNet.NetLogic.AutorizeUserGen(userAutorizationData);
            if (authResult.BooleanValue) 
            {
                FormsManager.mainForm.Show();
                Hide();
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Autorization failed \n" + authResult.StringValue);
            }
        }
        private void signUpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            FormsManager.registrationForm.Show();
            Hide();
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PassTextBox_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void AutorizationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (true)
            {
                FormsManager.dummyForm.Close();
            }
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            txtServerUrl.Visible = !txtServerUrl.Visible;

        }

        private void txtServerUrl_TextChanged(object sender, EventArgs e)
        {
            StaticNet.NetLogic.PaintServerUrl = txtServerUrl.Text;
        }
    }
}
