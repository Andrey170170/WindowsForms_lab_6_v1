using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_lab_6_v1
{
    public partial class Account
    {
        public Account(string login, string password, string role)
        {
            AC_Login = login;
            AC_Password = password;
            AC_Role = role;
        }
    }
}
