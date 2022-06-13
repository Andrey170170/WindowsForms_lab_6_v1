using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace WindowsForms_lab_6_v1
{
    public partial class OrderEditing : Form
    {
        private readonly Order _order = new Order();
        private readonly Portfolio _portfolio = new Portfolio();


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
            using (var db = new lab_OAIP_6_v1Entities())
            {
                _portfolio = db.Portfolios.FirstOrDefault(por => por.POR_ORD_ID == _order.ORD_ID) ?? new Portfolio();

                OrderALogin_TB.Text = db.Accounts.First(account => account.AC_Account_ID == order.ORD_AC_Account_ID)
                    .AC_Login;

                OrderCLogin_TB.Text = _portfolio.POR_CUS_ID != null
                    ? db.Accounts.First(account => account.AC_Account_ID == _portfolio.POR_CUS_ID).AC_Login
                    : "";
            }

            ChangeState(false);
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
                    db.Entry(_order).State = EntityState.Modified;
                    db.SaveChanges();
                }

                using (var db = new lab_OAIP_6_v1Entities())
                {
                    var artistId = db.Accounts.FirstOrDefault(account => account.AC_Login == OrderALogin_TB.Text);
                    _portfolio.POR_ART_ID = artistId.AC_Account_ID;
                    if (OrderCLogin_TB.Text != "")
                    {
                        var customerId = db.Accounts.FirstOrDefault(account => account.AC_Login == OrderCLogin_TB.Text);
                        _portfolio.POR_CUS_ID =
                            customerId?.AC_Account_ID ?? throw new Exception("Заказчика с таким логином не существует");
                    }

                    _portfolio.POR_ORD_ID = _order.ORD_ID;

                    db.Entry(_portfolio).State = EntityState.Modified;
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
            Order_Img.Image = _order.ORD_Picture == null ? null : MyMethods.ByteArrayToImage(_order.ORD_Picture);
            OrderName_TB.Text = _order.ORD_Name;
            using (var db = new lab_OAIP_6_v1Entities())
            {
                OrderALogin_TB.Text = db.Accounts.FirstOrDefault(account => account.AC_Account_ID == _order.ORD_AC_Account_ID)?
                    .AC_Login;
                OrderCLogin_TB.Text = _portfolio.POR_CUS_ID != null
                    ? db.Accounts.First(account => account.AC_Account_ID == _portfolio.POR_CUS_ID).AC_Login
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
                using (var db = new lab_OAIP_6_v1Entities())
                {
                    db.Entry(_order).State = EntityState.Deleted;
                    var portfolio = db.Portfolios.FirstOrDefault(port => port.POR_ORD_ID == _order.ORD_ID);
                    db.Entry(portfolio).State = EntityState.Deleted;
                    db.SaveChanges();
                }

                Close();
                MessageBox.Show(@"Удаление успешно");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ChangeState(bool state = true)
        {
            if (Order_Img != null) Order_Img.Enabled = state;
            if (OrderName_TB != null) OrderName_TB.Enabled = state;
            if (OrderALogin_TB != null) OrderALogin_TB.Enabled = state;
            if (OrderCLogin_TB != null) OrderCLogin_TB.Enabled = state;
            if (OrderPrice_TB != null) OrderPrice_TB.Enabled = state;
            if (OrderDecs_TB != null) OrderDecs_TB.Enabled = state;
            if (Save_B != null) Save_B.Enabled = state;
            if (Cancel_B != null) Cancel_B.Enabled = state;
            if (PlaceImg_B != null) PlaceImg_B.Enabled = state;
            if (ChangeImg_B != null) ChangeImg_B.Enabled = state;
            if (DeleteImg_B != null) DeleteImg_B.Enabled = state;
        }

        private void SaveImg_B_Click(object sender, EventArgs e)
        {
            if (SaveImg_D.ShowDialog() == DialogResult.Cancel)
                return;
            var path = SaveImg_D.FileName;
            File.WriteAllBytes(path, MyMethods.ImageToByteArray(Order_Img.Image));
            MessageBox.Show("Скачано успешно");
        }

        private void DeleteImg_B_Click(object sender, EventArgs e)
        {
            Order_Img.Image = new Bitmap(Order_Img.Width, Order_Img.Height);
        }
    }
}