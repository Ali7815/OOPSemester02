using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaicSignInUp.BL
{
    class MUser
    {
        public string userName;
        public string password;
        public string userRole;
        static List<MUser> usersList = new List<MUser>();
        public MUser(string userName,string password,string userRole)
        {
            this.userName = userName;
            this.password = password;
            this.userRole = userRole;
        }
        public MUser(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
            this.userRole = "NA";
        }
        static public MUser checkuser(MUser user)
        {
            foreach (MUser storedUser in usersList)
            {
                if(storedUser.userName==user.userName && storedUser.password==user.password)
                {
                    return storedUser;
                }
            }
            return null;
        }
        static public bool isAdmin(MUser user)
        {
            if(user.userRole=="Admin")
            {
                return true;
            }
            return false;
        }
        static public void adduserstoList(MUser user)
        {
            usersList.Add(user);
        }

    }
}
