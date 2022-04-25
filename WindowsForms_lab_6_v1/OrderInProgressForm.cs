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
    public partial class OrderInProgressForm : Form
    {
        private readonly Order _order;
        private readonly OrdersInProgress _orderIp;

        public OrderInProgressForm()
        {
            InitializeComponent();
        }

        public OrderInProgressForm(OrdersInProgress orderIP)
        {
            InitializeComponent();
            _orderIp = orderIP;


            using (var db = new lab_OAIP_6_v1Entities())
            {
                _order = db.Orders.FirstOrDefault(order => order.ORD_ID == orderIP.OIP_ORD_ID);
                OrderName_TB.Text = _order?.ORD_Name;
                OrderPrice_TB.Text = _order?.ORD_Cost.ToString();
                OrderDecs_TB.Text = _order?.ORD_Description;
                Order_Img.Image = MyMethods.ByteArrayToImage(_order?.ORD_Picture);
                OrderALogin_TB.Text = db.Accounts
                    .FirstOrDefault(account1 => account1.AC_Account_ID == orderIP.OIP_ART_ID)?.AC_Login;
                OrderCLogin_TB.Text = db.Accounts
                    .FirstOrDefault(account1 => account1.AC_Account_ID == orderIP.OIP_Cus_ID)?.AC_Login;
            }
        }

        private void Upload_B_Click(object sender, EventArgs e)
        {
            if (OrderImage_D.ShowDialog() == DialogResult.Cancel)
                return;
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

        private void SaveImg_B_Click(object sender, EventArgs e)
        {
            if (SaveImg_D.ShowDialog() == DialogResult.Cancel)
                return;
            var path = SaveImg_D.FileName;
            File.WriteAllBytes(path, MyMethods.ImageToByteArray(Order_Img.Image));
            MessageBox.Show("Скачано успешно");
        }

        private void Delete_B_Click(object sender, EventArgs e)
        {
            Order_Img.Image = new Bitmap(Order_Img.Width, Order_Img.Height);
        }

        private void Save_B_Click(object sender, EventArgs e)
        {
            try
            {
                _order.ORD_Picture = MyMethods.ImageToByteArray(Order_Img.Image);
                using (var db = new lab_OAIP_6_v1Entities())
                {
                    db.Entry(_order).State = EntityState.Modified;
                    db.SaveChanges();
                }

                MessageBox.Show("Сохранение успешно");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Exit_B_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void End_B_Click(object sender, EventArgs e)
        {
            try
            {
                _order.ORD_Picture = MyMethods.ImageToByteArray(Order_Img.Image);
                _order.ORD_ST_ID = 5;
                var newOrderForArt = new Order();
                newOrderForArt.ORD_AC_Account_ID = _orderIp.OIP_ART_ID;
                newOrderForArt.ORD_Name = _order.ORD_Name;
                newOrderForArt.ORD_ST_ID = 5;
                newOrderForArt.ORD_Picture = _order.ORD_Picture;
                newOrderForArt.ORD_Cost = _order.ORD_Cost;
                newOrderForArt.ORD_Description = _order.ORD_Description;
                var portfolio = new Portfolio();
                portfolio.POR_ART_ID = _orderIp.OIP_ART_ID;
                portfolio.POR_CUS_ID = _orderIp.OIP_Cus_ID;
                using (var db = new lab_OAIP_6_v1Entities())
                {
                    db.Entry(_order).State = EntityState.Modified;
                    db.SaveChanges();
                }
                using (var db = new lab_OAIP_6_v1Entities())
                {
                    db.Entry(_orderIp).State = EntityState.Deleted;
                    db.Entry(newOrderForArt).State = EntityState.Added;
                    db.SaveChanges();
                }

                using (var db = new lab_OAIP_6_v1Entities())
                {
                    portfolio.POR_ORD_ID =
                        db.Orders.Where(order => order.ORD_AC_Account_ID == newOrderForArt.ORD_AC_Account_ID).ToList().Last().ORD_ID;

                    db.Entry(portfolio).State = EntityState.Added;
                    db.SaveChanges();
                }

                MessageBox.Show("Работа успешно завершена");
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}