using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_lab_6_v1
{
    public partial class PreviewOrder : Form
    {
        private readonly Order _order = new Order();
        private readonly Account _account = new Account();
        private readonly OrdersInProgress _orderInProgress = new OrdersInProgress();
        public PreviewOrder()
        {
            InitializeComponent();
        }
        public PreviewOrder(Order order, Account account)
        {
            InitializeComponent();
            _order = order;
            _account = account;
            OrderName_TB.Text = order.ORD_Name;
            OrderPrice_TB.Text = order.ORD_Cost.ToString();
            OrderDecs_TB.Text = order.ORD_Description;
            using (var db = new lab_OAIP_6_v1Entities())
            {
                OrderCLogin_TB.Text = db.Accounts
                    .FirstOrDefault(account1 => account1.AC_Account_ID == order.ORD_AC_Account_ID)?.AC_Login;
            }
        }

        private void Select_B_Click(object sender, EventArgs e)
        {
            try
            {
                _order.ORD_ST_ID = 4;
                _orderInProgress.OIP_ORD_ID = _order.ORD_ID;
                _orderInProgress.OIP_Cus_ID = _order.ORD_AC_Account_ID;
                _orderInProgress.OIP_ART_ID = _account.AC_Account_ID;
                using (var db = new lab_OAIP_6_v1Entities())
                {
                    db.Entry(_order).State = EntityState.Modified;
                    db.Entry(_orderInProgress).State = EntityState.Added;
                    db.SaveChanges();
                }
                MessageBox.Show("Успешно");
                this.Close();
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
    }
}
