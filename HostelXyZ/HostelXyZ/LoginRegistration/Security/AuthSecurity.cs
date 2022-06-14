using System;
using System.Collections.Generic;
using System.Text;

namespace HostelXyZ.LoginRegistration.Security
{
    public class AuthSecurity
    {
        public bool LoginSecurity(string Email, string Password)
        {
            return string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password)
                ? false
                : Equals(Email, "sams52tas@gmail.com") || Equals(Password, "123");
        }
    }
}
