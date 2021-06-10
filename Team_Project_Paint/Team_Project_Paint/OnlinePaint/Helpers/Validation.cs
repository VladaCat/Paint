using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Team_Project_Paint.Class.Helpers
{
    public class Validation
    {
        public bool EmailValidate(string email)
        {
           return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }

        public bool PasswordValidate(string password)
        {
            return Regex.IsMatch(password, @"^(?=.{8,16}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).*$");
        }

        public bool FirstLastNameValidation(string name)
        {
            return name.Length >= 2 && name.Length <= 30;
        }
    }
}
