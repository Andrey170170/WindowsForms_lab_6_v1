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

//// 
//// ChangeImg_B
//// 
//this.ChangeImg_B.Location = new System.Drawing.Point(224, 269);
//this.ChangeImg_B.Name = "ChangeImg_B";
//this.ChangeImg_B.Size = new System.Drawing.Size(75, 23);
//this.ChangeImg_B.TabIndex = 23;
//this.ChangeImg_B.Text = "Изменить";
//this.ChangeImg_B.UseVisualStyleBackColor = true;
//this.ChangeImg_B.Click += new System.EventHandler(this.Order_Img_Click);
//// 
//// SaveImg_B
//// 
//this.SaveImg_B.Location = new System.Drawing.Point(305, 269);
//this.SaveImg_B.Name = "SaveImg_B";
//this.SaveImg_B.Size = new System.Drawing.Size(75, 23);
//this.SaveImg_B.TabIndex = 24;
//this.SaveImg_B.Text = "Скачать";
//this.SaveImg_B.UseVisualStyleBackColor = true;
//this.SaveImg_B.Click += new System.EventHandler(this.SaveImg_B_Click);
//// 
//// DeleteImg_B
//// 
//this.DeleteImg_B.Location = new System.Drawing.Point(143, 269);
//this.DeleteImg_B.Name = "DeleteImg_B";
//this.DeleteImg_B.Size = new System.Drawing.Size(75, 23);
//this.DeleteImg_B.TabIndex = 25;
//this.DeleteImg_B.Text = "Удалить";
//this.DeleteImg_B.UseVisualStyleBackColor = true;
//this.DeleteImg_B.Click += new System.EventHandler(this.DeleteImg_B_Click);
//// 
//// PlaceImg_B
//// 
//this.PlaceImg_B.Location = new System.Drawing.Point(62, 269);
//this.PlaceImg_B.Name = "PlaceImg_B";
//this.PlaceImg_B.Size = new System.Drawing.Size(75, 23);
//this.PlaceImg_B.TabIndex = 26;
//this.PlaceImg_B.Text = "Установить";
//this.PlaceImg_B.UseVisualStyleBackColor = true;
//this.PlaceImg_B.Click += new System.EventHandler(this.Order_Img_Click);


//// 
//// Save_B
//// 
//this.Save_B.Enabled = false;
//this.Save_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//this.Save_B.Location = new System.Drawing.Point(93, 705);
//this.Save_B.Name = "Save_B";
//this.Save_B.Size = new System.Drawing.Size(111, 43);
//this.Save_B.TabIndex = 0;
//this.Save_B.Text = "Сохранить";
//this.Save_B.UseVisualStyleBackColor = true;
//this.Save_B.Click += new System.EventHandler(this.Save_B_Click);
//// 
//// Cancel_B
//// 
//this.Cancel_B.Enabled = false;
//this.Cancel_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//this.Cancel_B.Location = new System.Drawing.Point(210, 705);
//this.Cancel_B.Name = "Cancel_B";
//this.Cancel_B.Size = new System.Drawing.Size(111, 43);
//this.Cancel_B.TabIndex = 1;
//this.Cancel_B.Text = "Сбросить";
//this.Cancel_B.UseVisualStyleBackColor = true;
//this.Cancel_B.Click += new System.EventHandler(this.Cancel_B_Click);
//// 
//// Change_B
//// 
//this.Change_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//this.Change_B.Location = new System.Drawing.Point(327, 705);
//this.Change_B.Name = "Change_B";
//this.Change_B.Size = new System.Drawing.Size(111, 43);
//this.Change_B.TabIndex = 2;
//this.Change_B.Text = "Изменить";
//this.Change_B.UseVisualStyleBackColor = true;
//this.Change_B.Click += new System.EventHandler(this.Change_B_Click);
//// 
//// Delete_B
//// 
//this.Delete_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//this.Delete_B.Location = new System.Drawing.Point(444, 705);
//this.Delete_B.Name = "Delete_B";
//this.Delete_B.Size = new System.Drawing.Size(111, 43);
//this.Delete_B.TabIndex = 3;
//this.Delete_B.Text = "Удалить";
//this.Delete_B.UseVisualStyleBackColor = true;
//this.Delete_B.Click += new System.EventHandler(this.Delete_B_Click);