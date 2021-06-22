using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Team_Project_Paint.Helpers
{
    public class Validation
    {
        public bool EmailValidate(string email)
        {
           return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }

        public (bool result, string message) PasswordValidate(string password)
        {
            bool result = false;
            string message;

            if (Regex.IsMatch(password, @"^(?=.{8,16}$).*$"))
            {
                result = true;
            }
            else
            {
                message = TextMessages.txtIncorrectPasswordMessage1;
                return (result, message);
            }

            if (result && Regex.IsMatch(password, @"^(?=.*?[a-z]).*$"))
            {

            }
            else
            {
                result = false;
                message = TextMessages.txtIncorrectPasswordMessage2;
                return (result, message);
            }

            if (result && Regex.IsMatch(password, @"^(?=.*?[A-Z]).*$"))
            {

            }
            else
            {
                result = false;
                message = TextMessages.txtIncorrectPasswordMessage3;
                return (result, message);
            }

            if (result && Regex.IsMatch(password, @"^(?=.*?[0-9]).*$"))
            {

            }
            else
            {
                result = false;
                message = TextMessages.txtIncorrectPasswordMessage4;
                return (result, message);
            }

                message = TextMessages.txtIncorrectPasswordMessage5;
                return (result, message);

            //return Regex.IsMatch(password, @"^(?=.{8,16}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).*$");



        }

        public bool FirstLastNameValidation(string name)
        {
            return name.Length >= 2 && name.Length <= 30;
        }
    }
}
