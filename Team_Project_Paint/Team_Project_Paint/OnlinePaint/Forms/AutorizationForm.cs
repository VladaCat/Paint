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

            bool authResult = false;
            //TODO add validation. If successful - create request
            var userAutorizationData = new UserAutorizationData()
            {
                Login = txtLogin.Text,
                Password=txtPassword.Text
            };
            authResult= StaticNet.NetLogic.AutorizeUser(userAutorizationData);

            if (authResult) //TODO: add condition
            {
                
                FormsManager.mainForm.Show();
                Hide();
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Something gone wrong");
            }
            
        }

        private void signUpLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            FormsManager.registrationForm.Show();
            Hide();
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            //_isEmail = Regex.IsMatch(loginTextBox.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            //if (_isEmail)
            //{
            //    loginLbl.ForeColor = Color.Green;
            //}
            //else
            //{
            //    loginLbl.ForeColor = Color.Red;
            //}

            //if (_isEmail && _isPass)
            //{
            //    signInBtn.Enabled = true;
            //}
            //else
            //{
            //    signInBtn.Enabled = false;
            //}
        }

        private void PassTextBox_TextChanged(object sender, EventArgs e)
        {
            ////https://docs.microsoft.com/ru-ru/dotnet/api/system.windows.forms.control.validated?view=net-5.0
            ////Условия: строка должна содержать от 8 до 16 символов.
            ////строка должна содержать хотя бы одно число. строка должна
            ////содержать хотя бы одну заглавную букву. строка должна
            ////содержать хотя бы одну строчную букву.
            //_isPass = Regex.IsMatch(PassTextBox.Text, @"^(?=.{8,16}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).*$");
            //if (_isPass)
            //{
            //    passLbl.ForeColor = Color.Green;
            //}
            //else
            //{
            //    passLbl.ForeColor = Color.Red;
            //}

            //if (_isEmail && _isPass)
            //{
            //    signInBtn.Enabled = true;
            //}
            //else
            //{
            //    signInBtn.Enabled = false;
            //}

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
