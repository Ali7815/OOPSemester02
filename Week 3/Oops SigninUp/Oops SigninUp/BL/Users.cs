using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_SigninUp.BL
{
    class Users
    {
        public string name;
        public string password;
        public string role;
        public Users(string name,string password,string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }
        public Users(string name,string password)
        {
            this.name = name;
            this.password = password;
            this.role = "NA";
        }
        public bool isAdmin()
        {
            if(role=="Admin")
            {
                return true;
            }
            return false;
        }
    }
}
