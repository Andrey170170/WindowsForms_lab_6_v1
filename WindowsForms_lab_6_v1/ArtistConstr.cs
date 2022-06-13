using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_lab_6_v1
{
    public partial class Artist
    {
        public Artist () {}
        public Artist(int id, string name, int age)
        {
            ART_AC_Account_ID = id;
            ART_FullName = name;
            ART_Age = age;
        }
    }
}
