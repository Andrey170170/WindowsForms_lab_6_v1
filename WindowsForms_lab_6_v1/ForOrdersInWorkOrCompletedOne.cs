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
    public partial class ForOrdersInWorkOrCompletedOne : Form
    {
        private readonly Order _order;
        public ForOrdersInWorkOrCompletedOne()
        {
            InitializeComponent();
        }

        public ForOrdersInWorkOrCompletedOne(Order order)
        {
            InitializeComponent();
            _order = order;
            try
            {
                Order_Img.Image = MyMethods.ByteArrayToImage(_order.ORD_Picture);
                OrderName_TB.Text = _order.ORD_Name;
                OrderPrice_TB.Text = _order.ORD_Cost.ToString();
                OrderDecs_TB.Text = _order.ORD_Description;
                using (var db = new lab_OAIP_6_v1Entities())
                {
                    OrderCLogin_TB.Text = db.Accounts
                        .FirstOrDefault(account => account.AC_Account_ID == _order.ORD_AC_Account_ID)?.AC_Login;
                    var status = db.Statuses.FirstOrDefault(statusL => statusL.ST_ID == _order.ORD_ST_ID);
                    Status_L.Text = status?.ST_Name;
                    int? artId;
                    switch (status?.ST_ID)
                    {
                        case 4:
                            Status_L.ForeColor = Color.Yellow;
                            artId = db.OrdersInProgresses.FirstOrDefault(orderL => orderL.OIP_ORD_ID == order.ORD_ID)?
                                .OIP_ART_ID;
                            OrderALogin_TB.Text = db.Accounts.FirstOrDefault(account => account.AC_Account_ID == artId)?
                                .AC_Login;
                            break;
                        case 5:
                            Status_L.ForeColor = Color.Green;
                            //artId = db.Portfolios.FirstOrDefault(portfolio => portfolio.POR_ORD_ID == order.ORD_ID)?
                            //    .OIP_ART_ID;
                            //OrderALogin_TB.Text = db.Accounts.FirstOrDefault(account => account.AC_Account_ID == artId)?
                            //    .AC_Login;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(status.ST_ID));
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void SaveImg_B_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaveImg_D.ShowDialog() == DialogResult.Cancel)
                    return;
                var path = SaveImg_D.FileName;
                File.WriteAllBytes(path, MyMethods.ImageToByteArray(Order_Img.Image));
                MessageBox.Show("Скачано успешно");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Save_B_Click(object sender, EventArgs e)
        {
            _order.ORD_Name = OrderName_TB.Text;
            _order.ORD_Cost = int.Parse(OrderPrice_TB.Text);
            _order.ORD_Description = OrderDecs_TB.Text;
            try
            {
                using (var db = new lab_OAIP_6_v1Entities())
                {
                    db.Entry(_order).State = EntityState.Modified;
                    db.SaveChanges();
                }

                MessageBox.Show("Сохранено успешно");
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

        private void Delete_B_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new lab_OAIP_6_v1Entities())
                {
                    db.Entry(_order).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}

