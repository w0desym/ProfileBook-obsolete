﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProfileBook
{
    public class AuthorizationInfo
    {
        private string login;
        private string password;

        public AuthorizationInfo()
        {

        }

        public string Login
        {
            get { return this.login; }
            set
            {
                this.login = value;
            }
        }

        public string Password
        {
            get { return this.password; }
            set
            {
                this.password = value;
            }
        }
    }
}
