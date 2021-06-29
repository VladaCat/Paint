using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team_Project_Paint.Helpers;
using Team_Project_Paint.Net;

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
            bool isValid = true;
            bool regiserResult = false;

            Validation validation = new Validation();

            if (validation.EmailValidate(txtEmail.Text) == false)
            {
                isValid = false;
            }
            if (validation.FirstLastNameValidation(txtFirstName.Text) == false)
            {
                isValid = false;
            }
            if (validation.FirstLastNameValidation(txtLastName.Text) == false)
            {
                isValid = false;
            }
            if (validation.PasswordValidate(txtPassword.Text).result == false)
            {
                isValid = false;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                isValid = false;
            }




            if (isValid) //TODO add condition
            {
                var userRegistrationData = new UserRegistrationData()
                {
                    Login = txtEmail.Text,
                    Password = txtPassword.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text
                };

                //regiserResult = StaticNet.NetLogic.RegisterUser(userRegistrationData);
                regiserResult = StaticNet.NetLogic.RegisterUserGen(userRegistrationData);
            }
            else
            {
                MessageBox.Show("Please enter correct value");
            }

            if (regiserResult)
            {
                FormsManager.autorizationForm.txtLogin.Text = txtEmail.Text;
                FormsManager.autorizationForm.txtPassword.Text = txtPassword.Text;
                FormsManager.autorizationForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Registration failed");
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
