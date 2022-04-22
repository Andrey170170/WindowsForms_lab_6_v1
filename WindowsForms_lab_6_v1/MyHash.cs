using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace WindowsForms_lab_6_v1
{
    public class MyHash
    {
        public static string GetHashString(string s)
        {
            var bytes = Encoding.Unicode.GetBytes(s);
            var CSP = new MD5CryptoServiceProvider();
            var byteHash = CSP.ComputeHash(bytes);
            return byteHash.Aggregate("", (current, b) => current + $"{b:x2}");
        }
    }
}