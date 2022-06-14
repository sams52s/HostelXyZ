﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HostelXyZ.LoginRegistration.Model
{
    public class UserModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Image { get; set; }
    }
}
