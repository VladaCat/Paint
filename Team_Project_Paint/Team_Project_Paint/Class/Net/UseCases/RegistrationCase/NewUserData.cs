﻿using System;

namespace Team_Project_Paint.Net
{
    public class NewUserData
    {
        public string Login { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public bool IsValid()
        {
            return true;
        }

        public void Validate()
        {
            if (Login == null || Login.Length <= 1 || Login.Length > 20) throw new ArgumentException(nameof(Login));
        }
    }
}
