using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_lab_6_v1
{
    public partial class Customer
    {
        public Customer(int id, string Name, int age)
        {
            CUS_AC_Account_ID = id;
            CUS_FullName = Name;
            CUS_Age = age;
        }
    }
}
