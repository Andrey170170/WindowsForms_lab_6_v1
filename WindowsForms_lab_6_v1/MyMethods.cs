using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms_lab_6_v1
{
    public class MyMethods
    {
        public static string GetHashString(string s)
        {
            var bytes = Encoding.Unicode.GetBytes(s);
            var CSP = new MD5CryptoServiceProvider();
            var byteHash = CSP.ComputeHash(bytes);
            return byteHash.Aggregate("", (current, b) => current + $"{b:x2}");
        }
        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            return Image.FromStream(new MemoryStream(byteArrayIn));
        }
        public static void UpdateLV(Account account, ImageList imageList, ListView listView)
        {
            using (var db = new OAIP_6_v1Entities())
            {
                var portfolioOrders = db.Orders.Where(order => order.ORD_AC_Account_ID == account.AC_Account_ID)
                    .ToList();
                imageList.ImageSize = new Size(64, 64);
                imageList.Images.Clear();
                foreach (var order in portfolioOrders)
                {
                    imageList.Images.Add(Image.FromStream(new MemoryStream(order.ORD_Picture)));
                }
                listView.Items.Clear();
                listView.LargeImageList = imageList;
                for (var i = 0; i < portfolioOrders.Count(); i++)
                {
                    listView.Items.Add(
                        new ListViewItem
                        {
                            Text = portfolioOrders.ElementAt(i).ORD_Name,
                            ImageIndex = i,
                            BackColor = Color.AntiqueWhite,
                            Tag = portfolioOrders[i]
                        }
                    );
                }
            }
        }
    }
}

//public Account(string login, string password, string role)
//{
//    AC_Login = login;
//    AC_Password = password;
//    AC_Role = role;
//}

//public Customer(int id, string Name, int age)
//{
//    CUS_AC_Account_ID = id;
//    CUS_FullName = Name;
//    CUS_Age = age;
//}

//public Artist(int id, string Name, int age)
//{
//    ART_AC_Account_ID = id;
//    ART_FullName = Name;
//    ART_Age = age;
//}