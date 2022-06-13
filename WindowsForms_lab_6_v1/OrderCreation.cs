using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_lab_6_v1
{
    public partial class OrderCreation : Form
    {
        private readonly int _id;
        private readonly Order _order = new Order();
        private readonly Portfolio _portfolio = new Portfolio();
        public OrderCreation()
        {
            InitializeComponent();
        }

        public OrderCreation(int userId)
        {
            InitializeComponent();
            _id = userId;
            using (var db = new lab_OAIP_6_v1Entities())
            {
                OrderALogin_TB.Text = db.Accounts.First(account => account.AC_Account_ID == userId)
                    .AC_Login;
            }
        }
        private void Save_B_Click(object sender, EventArgs e)
        {
            try
            {
                if (Order_Img.Image == null) throw new Exception("Выберете изображение");
                if (OrderName_TB.Text.Trim() == "") throw new Exception("Введите имя заказа");
                if (OrderALogin_TB.Text.Trim() == "") throw new Exception("Введите логин создателя");
                if (OrderPrice_TB.Text.Trim() == "") throw new Exception("Введите цену заказа");
                if (OrderDecs_TB.Text.Trim() == "") throw new Exception("Введите описание заказа");
                using (var db = new lab_OAIP_6_v1Entities())
                {
                    var artistId = db.Accounts.FirstOrDefault(account => account.AC_Login == OrderALogin_TB.Text);
                    _order.ORD_AC_Account_ID =
                        artistId?.AC_Account_ID ?? throw new Exception("Художника с таким логином не существует");
                    _order.ORD_Name = OrderName_TB.Text;
                    _order.ORD_Picture = MyMethods.ImageToByteArray(Order_Img.Image);
                    _order.ORD_Description = OrderDecs_TB.Text;
                    _order.ORD_Cost = int.Parse(OrderPrice_TB.Text);
                    _order.ORD_ST_ID = 5;
                    db.Entry(_order).State = EntityState.Added;
                    db.SaveChanges();
                }

                using (var db = new lab_OAIP_6_v1Entities())
                {
                    var artistId = db.Accounts.FirstOrDefault(account => account.AC_Login == OrderALogin_TB.Text);
                    _portfolio.POR_ART_ID = artistId?.AC_Account_ID ?? throw new Exception("Художника с таким логином не существует");
                    if (OrderCLogin_TB.Text != "")
                    {
                        var customerId = db.Accounts.FirstOrDefault(account => account.AC_Login == OrderCLogin_TB.Text);
                        _portfolio.POR_CUS_ID =
                            customerId?.AC_Account_ID ?? throw new Exception("Заказчика с таким логином не существует");
                    }
                    _portfolio.POR_ORD_ID = db.Orders.Where(ord => ord.ORD_AC_Account_ID == artistId.AC_Account_ID).ToList().Last().ORD_ID;
                    db.Entry(_portfolio).State = EntityState.Added;
                    db.SaveChanges();
                }
                MessageBox.Show("Сохранение прошло успешно");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Cancel_B_Click(object sender, EventArgs e)
        {
            Order_Img.Image = null;
            OrderName_TB.Text = "";
            using (var db = new lab_OAIP_6_v1Entities())
            {
                OrderALogin_TB.Text = db.Accounts.FirstOrDefault(account => account.AC_Account_ID == _id)?
                    .AC_Login;
            }

            OrderCLogin_TB.Text = "";
            OrderPrice_TB.Text = "";
            OrderDecs_TB.Text = "";
        }

        private void Order_Img_Click(object sender, EventArgs e)
        {
            OrderImage_D.ShowDialog();
        }

        private void OrderImage_D_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                var path = OrderImage_D.FileName;
                if (path != "")
                    Order_Img.Image = MyMethods.ByteArrayToImage(File.ReadAllBytes(path));
                else
                    throw new Exception("Вы не выбрали файл");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void DeleteImg_B_Click(object sender, EventArgs e)
        {
            Order_Img.Image = null;
        }
    }
}
