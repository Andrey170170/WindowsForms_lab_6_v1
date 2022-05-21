using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_lab_6_v1
{
    public partial class ForJustCreatedOrders : Form
    {
        private readonly Account _account;
        private readonly Order _order = new Order();
        public ForJustCreatedOrders()
        {
            InitializeComponent();
        }

        public ForJustCreatedOrders(Account account)
        {
            InitializeComponent();
            Chanege_B.Enabled = false;
            Rollback_B.Enabled = false;
            Delete_B.Enabled = false;
            OrderCLogin_TB.Enabled = false;
            OrderALogin_TB.Enabled = false;

            _account = account;
            OrderCLogin_TB.Text = _account.AC_Login;
            Status_L.Text = "Не создан";
        }

        public ForJustCreatedOrders(Order order)
        {
            InitializeComponent();
            _order = order;
            ChangeState(false);

            FilingForm();
        }

        private void Save_B_Click(object sender, EventArgs e)
        {
            try
            {
                if (OrderName_TB.Text.Trim() == "") throw new Exception("Введите имя заказа");
                if (OrderPrice_TB.Text.Trim() == "") throw new Exception("Введите цену заказа");
                if (OrderDecs_TB.Text.Trim() == "") throw new Exception("Введите описание заказа");
                using (var db = new lab_OAIP_6_v1Entities())
                {
                    _order.ORD_AC_Account_ID = _account.AC_Account_ID;
                    _order.ORD_Name = OrderName_TB.Text;
                    _order.ORD_Description = OrderDecs_TB.Text;
                    if (!int.TryParse(OrderPrice_TB.Text, out var cost))
                        throw new Exception("Цена это число");
                    _order.ORD_Cost = cost;
                    if (_order.ORD_ID == 0)
                    {
                        _order.ORD_ST_ID = 3;
                        _order.ORD_Picture = MyMethods.ImageToByteArray(new Bitmap(1, 1));
                        db.Entry(_order).State = EntityState.Added;
                        db.SaveChanges();
                    }
                    else
                    {
                        db.Entry(_order).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }

                MessageBox.Show("Сохранение прошло успешно");
                ChangeState(false);
            }
            catch (DbEntityValidationException ex)
            {
                var error = "";
                foreach (var validationError in ex.EntityValidationErrors)
                {
                    error += "Object: " + validationError.Entry.Entity + '\n';
                    error = validationError.ValidationErrors.Aggregate(error, (current, err) => current + (err.ErrorMessage + '\n'));
                }
                MessageBox.Show(error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Change_B_Click(object sender, EventArgs e)
        {
            ChangeState();
        }

        private void Rollback_B_Click(object sender, EventArgs e)
        {
            FilingForm();
        }

        private void Cancel_B_Click(object sender, EventArgs e)
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

                MessageBox.Show("Удаление прошло успешно");
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ChangeState(bool state = true)
        {
            if (OrderName_TB != null) OrderName_TB.Enabled = state;
            if (OrderALogin_TB != null) OrderALogin_TB.Enabled = state;
            if (OrderCLogin_TB != null) OrderCLogin_TB.Enabled = state;
            if (OrderPrice_TB != null) OrderPrice_TB.Enabled = state;
            if (OrderDecs_TB != null) OrderDecs_TB.Enabled = state;
            if (Save_B != null) Save_B.Enabled = state;
            if (Cancel_B != null) Cancel_B.Enabled = state;
            if (Rollback_B != null) Rollback_B.Enabled = state;
        }

        private void FilingForm()
        {
            OrderName_TB.Text = _order.ORD_Name;
            OrderPrice_TB.Text = _order.ORD_Cost.ToString();
            OrderDecs_TB.Text = _order.ORD_Description;
            using (var db = new lab_OAIP_6_v1Entities())
            {
                OrderCLogin_TB.Text = db.Accounts.FirstOrDefault(account => account.AC_Account_ID == _order.ORD_AC_Account_ID)?.AC_Login;
                Status_L.Text = db.Statuses.FirstOrDefault(status => status.ST_ID == _order.ORD_ST_ID)?.ST_Name;
                var artId = db.OrdersInProgresses.FirstOrDefault(inProgress => inProgress.OIP_ORD_ID == _order.ORD_ID);
                if (artId != null)
                {
                    OrderALogin_TB.Text =
                        db.Accounts.FirstOrDefault(account => account.AC_Account_ID == artId.OIP_ART_ID)?.AC_Login;
                }
            }
        }
    }
}
