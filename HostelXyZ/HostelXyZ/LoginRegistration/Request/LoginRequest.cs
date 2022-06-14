using HostelXyZ.LoginRegistration.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace HostelXyZ.LoginRegistration.Request
{
    public class LoginRequest
    {

        public bool Login(string email, string password)
        {
            AuthSecurity authSecurity = new AuthSecurity();
            return authSecurity.LoginSecurity(email, password);
        }

    }
}
