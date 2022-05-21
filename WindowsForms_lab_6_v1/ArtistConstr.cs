using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_lab_6_v1
{
    public partial class Artist
    {
        public Artist(int id, string Name, int age)
        {
            ART_AC_Account_ID = id;
            ART_FullName = Name;
            ART_Age = age;
        }
    }
}
