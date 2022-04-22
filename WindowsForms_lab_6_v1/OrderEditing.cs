using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsForms_lab_6_v1
{
    public partial class OrderEditing : Form
    {
        private readonly Order _order;

        public OrderEditing()
        {
            InitializeComponent();
        }

        public OrderEditing(Order order)
        {
            InitializeComponent();
            _order = order;
            OrderName_TB.Text = order.ORD_Name;
            OrderPrice_TB.Text = order.ORD_Cost.ToString();
            OrderDecs_TB.Text = order.ORD_Description;
            var img = MyMethods.ByteArrayToImage(order.ORD_Picture);
            Order_Img.Image = MyMethods.ByteArrayToImage(order.ORD_Picture);
            using (var db = new OAIP_6_v1Entities())
            {
                OrderALogin_TB.Text = db.Accounts.First(account => account.AC_Account_ID == order.ORD_AC_Account_ID)
                    .AC_Login;
                OrderCLogin_TB.Text = order.ORD_Customer_ID != null
                    ? db.Accounts.First(account => account.AC_Account_ID == order.ORD_Customer_ID).AC_Login
                    : "";
            }
        }

        private void Change_B_Click(object sender, EventArgs e)
        {
            ChangeState();
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

        private void Save_B_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new OAIP_6_v1Entities())
                {
                    var artistId = db.Accounts.FirstOrDefault(account => account.AC_Login == OrderALogin_TB.Text);
                    
                    _order.ORD_AC_Account_ID =
                        artistId?.AC_Account_ID ?? throw new Exception("Художника с таким логином не существует");
                    if (OrderCLogin_TB.Text != "")
                    {
                        var customerId = db.Accounts.FirstOrDefault(account => account.AC_Login == OrderCLogin_TB.Text);
                        _order.ORD_Customer_ID =
                            customerId?.AC_Account_ID ?? throw new Exception("Заказчика с таким логином не существует");
                    }
                    _order.ORD_Name = OrderName_TB.Text;
                    _order.ORD_Picture = MyMethods.ImageToByteArray(Order_Img.Image);
                    _order.ORD_Description = OrderDecs_TB.Text;
                    _order.ORD_Cost = int.Parse(OrderPrice_TB.Text);
                    db.Entry(_order).State = EntityState.Modified;
                    db.SaveChanges();
                }
                ChangeState(false);
                MessageBox.Show("Сохранение прошло успешно");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Cancel_B_Click(object sender, EventArgs e)
        {
            Order_Img.Image = MyMethods.ByteArrayToImage(_order.ORD_Picture);
            OrderName_TB.Text = _order.ORD_Name;
            using (var db = new OAIP_6_v1Entities())
            {
                OrderALogin_TB.Text = db.Accounts.First(account => account.AC_Account_ID == _order.ORD_AC_Account_ID)
                    .AC_Login;
                OrderCLogin_TB.Text = _order.ORD_Customer_ID != null
                    ? db.Accounts.First(account => account.AC_Account_ID == _order.ORD_Customer_ID).AC_Login
                    : "";
            }
            OrderPrice_TB.Text = _order.ORD_Cost.ToString();
            OrderDecs_TB.Text = _order.ORD_Description;
            ChangeState(false);
        }

        private void Delete_B_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new OAIP_6_v1Entities())
                {
                    db.Entry(_order).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                this.Close();
                MessageBox.Show("Удаление успешно");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ChangeState(bool state = true)
        {
            Order_Img.Enabled = state;
            OrderName_TB.Enabled = state;
            OrderALogin_TB.Enabled = state;
            OrderCLogin_TB.Enabled = state;
            OrderPrice_TB.Enabled = state;
            OrderDecs_TB.Enabled = state;
            Save_B.Enabled = state;
            Cancel_B.Enabled = state;
        }
    }
}