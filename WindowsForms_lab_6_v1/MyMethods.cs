using System;
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
            var csp = new MD5CryptoServiceProvider();
            var byteHash = csp.ComputeHash(bytes);
            return byteHash.Aggregate(string.Empty, (current, b) => current + $"{b:x2}");
        }

        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            var ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            return Image.FromStream(new MemoryStream(byteArrayIn));
        }

        public static void UpdateLV(Account account, ImageList imageList, ListView listView)
        {
            using (var db = new lab_OAIP_6_v1Entities())
            {
                var orders = db.Orders.Where(order => order.ORD_AC_Account_ID == account.AC_Account_ID)
                    .ToList();
                imageList.ImageSize = new Size(64, 64);
                imageList.Images.Clear();
                foreach (var order in orders)
                {
                    imageList.Images.Add(Image.FromStream(new MemoryStream(order.ORD_Picture)));
                }

                listView.Items.Clear();
                listView.LargeImageList = imageList;
                for (var i = 0; i < orders.Count(); i++)
                {
                    listView.Items.Add(
                        new ListViewItem
                        {
                            Text = orders.ElementAt(i).ORD_Name,
                            ImageIndex = i,
                            Tag = orders[i]
                        }
                    );
                }
            }
        }

        public static void UpdateLV(Account account, ListView listView)
        {
            listView.Items.Clear();
            using (var db = new lab_OAIP_6_v1Entities())
            {
                var orders = db.Orders.Where(order => order.ORD_AC_Account_ID == account.AC_Account_ID)
                    .ToList();
                foreach (var order in orders)
                {
                    var item = listView.Items.Add(order.ORD_Name);
                    item.UseItemStyleForSubItems = false;
                    item.Tag = order;
                    var subItemCost = item.SubItems.Add(order.ORD_Cost.ToString());
                    var status = db.Statuses.FirstOrDefault(stat => stat.ST_ID == order.ORD_ST_ID);
                    var subItemStatus = item.SubItems.Add(status.ST_Name);
                    switch (status.ST_ID)
                    {
                        case 3:
                            subItemStatus.ForeColor = Color.Red;
                            break;
                        case 4:
                            subItemStatus.ForeColor = Color.Yellow;
                            break;
                        case 5:
                            subItemStatus.ForeColor = Color.Green;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(status.ST_ID));
                    }
                }
            }
        }

        public static void UpdateOrderLV(Account account, ListView listView)
        {
            listView.Items.Clear();
            using (var db = new lab_OAIP_6_v1Entities())
            {
                var orders = db.Orders.Where(order => order.ORD_ST_ID == 3).ToList();
                foreach (var order in orders)
                {
                    var item = listView.Items.Add(order.ORD_Name);
                    item.UseItemStyleForSubItems = false;
                    item.Tag = order;
                    var subItemCost = item.SubItems.Add(order.ORD_Cost.ToString());
                    var subItemOwner = item.SubItems.Add(db.Accounts.FirstOrDefault(account1 => account1.AC_Account_ID == order.ORD_AC_Account_ID)?.AC_Login);
                }


            }
        }

        public static void UpdateMyOrderLV(Account account, ListView listView)
        {
            listView.Items.Clear();
            using (var db = new lab_OAIP_6_v1Entities())
            {
                var myOrders = db.OrdersInProgresses.Where(order => order.OIP_ART_ID == account.AC_Account_ID).ToList();
                foreach (var myOrder in myOrders)
                {
                    var order = db.Orders.First(ord => ord.ORD_ID == myOrder.OIP_ORD_ID);
                    var item = listView.Items.Add(order.ORD_Name);
                    item.UseItemStyleForSubItems = false;
                    item.Tag = myOrder;
                    var subItemCost = item.SubItems.Add(order.ORD_Cost.ToString());
                    var subItemOwner = item.SubItems.Add(db.Accounts.FirstOrDefault(account1 => account1.AC_Account_ID == order.ORD_AC_Account_ID)?.AC_Login);
                }
            }
        }
    }
}