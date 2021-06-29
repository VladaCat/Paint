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
            BoolStringType registerResult = null;
            string ValidationMessage="";

            Validation validation = new Validation();

            if (validation.EmailValidate(txtEmail.Text) == false)
            {
                isValid = false;
                ValidationMessage += TextMessages.txtLoginIsNotEmail +"\n";
            }
            if (validation.FirstLastNameValidation(txtFirstName.Text) == false)
            {
                isValid = false;
                ValidationMessage += TextMessages.txtIncorrectNameLength + "\n";
            }
            if (validation.FirstLastNameValidation(txtLastName.Text) == false)
            {
                isValid = false;
                ValidationMessage += TextMessages.txtIncorrectNameLength + "\n";
            }

            var validationResult = validation.PasswordValidate(txtPassword.Text);
            if (validationResult.result == false)
            {
                isValid = false;
                ValidationMessage += validationResult.message + "\n";
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                isValid = false;
                ValidationMessage += TextMessages.txtDiferentPasswords +"\n";
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
                registerResult = StaticNet.NetLogic.RegisterUserGen(userRegistrationData);
            }
            else
            {
                MessageBox.Show(ValidationMessage);
            }

            
            if ((registerResult==null)?  false: registerResult.BooleanValue    )
            {
                FormsManager.autorizationForm.txtLogin.Text = txtEmail.Text;
                FormsManager.autorizationForm.txtPassword.Text = txtPassword.Text;
                FormsManager.autorizationForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Registration failed \n" + registerResult?.StringValue );
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
