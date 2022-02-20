using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_02._21._2022
{
    internal class Admin : User
    {
        public bool IsSuperAdmin;
        public string Section;

        public Admin(string username, string password, bool issuperadmin , string section ) : base(username, password)
        {
            IsSuperAdmin = issuperadmin;
            Section = section;
        }
        public string GetInfo()
        {
            return getinfo()+$"\nIsSuperAdmin:{IsSuperAdmin}\nSection:{Section}";
        }
    }
}
