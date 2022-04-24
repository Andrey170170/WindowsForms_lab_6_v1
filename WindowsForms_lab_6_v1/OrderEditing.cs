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

        public OrderEditing(int userId)
        {
            InitializeComponent();

            Save_B = new Button();
            Cancel_B = new Button();
            DeleteImg_B = new Button();
            PlaceImg_B = new Button();
            // 
            // Save_B
            // 
            Save_B.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Save_B.Location = new Point(231, 705);
            Save_B.Name = "Save_B";
            Save_B.Size = new Size(111, 43);
            Save_B.TabIndex = 0;
            Save_B.Text = "Сохранить";
            Save_B.UseVisualStyleBackColor = true;
            Save_B.Click += Save_B_Click;
            // 
            // Cancel_B
            // 
            Cancel_B.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cancel_B.Location = new Point(348, 705);
            Cancel_B.Name = "Cancel_B";
            Cancel_B.Size = new Size(111, 43);
            Cancel_B.TabIndex = 1;
            Cancel_B.Text = "Сбросить";
            Cancel_B.UseVisualStyleBackColor = true;
            Cancel_B.Click += Cancel_B_Click;
            // 
            // DeleteImg_B
            // 
            DeleteImg_B.Location = new Point(143, 269);
            DeleteImg_B.Name = "DeleteImg_B";
            DeleteImg_B.Size = new Size(75, 23);
            DeleteImg_B.TabIndex = 25;
            DeleteImg_B.Text = "Удалить";
            DeleteImg_B.UseVisualStyleBackColor = true;
            DeleteImg_B.Click += DeleteImg_B_Click;
            // 
            // PlaceImg_B
            // 
            PlaceImg_B.Location = new Point(62, 269);
            PlaceImg_B.Name = "PlaceImg_B";
            PlaceImg_B.Size = new Size(75, 23);
            PlaceImg_B.TabIndex = 26;
            PlaceImg_B.Text = "Установить";
            PlaceImg_B.UseVisualStyleBackColor = true;
            PlaceImg_B.Click += Order_Img_Click;

            Controls.Add(Cancel_B);
            Controls.Add(Save_B);
            Controls.Add(PlaceImg_B);
            Controls.Add(DeleteImg_B);

            using (var db = new lab_OAIP_6_v1Entities())
            {
                OrderALogin_TB.Text = db.Accounts.First(account => account.AC_Account_ID == userId)
                    .AC_Login;
            }
        }

        public OrderEditing(Order order)
        {
            InitializeComponent();

            Save_B = new Button();
            Cancel_B = new Button();
            Change_B = new Button();
            Delete_B = new Button();
            ChangeImg_B = new Button();
            SaveImg_B = new Button();
            DeleteImg_B = new Button();
            // 
            // Save_B
            // 
            Save_B.Enabled = false;
            Save_B.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Save_B.Location = new Point(93, 705);
            Save_B.Name = "Save_B";
            Save_B.Size = new Size(111, 43);
            Save_B.TabIndex = 0;
            Save_B.Text = "Сохранить";
            Save_B.UseVisualStyleBackColor = true;
            Save_B.Click += Save_B_Click;
            // 
            // Cancel_B
            // 
            Cancel_B.Enabled = false;
            Cancel_B.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cancel_B.Location = new Point(210, 705);
            Cancel_B.Name = "Cancel_B";
            Cancel_B.Size = new Size(111, 43);
            Cancel_B.TabIndex = 1;
            Cancel_B.Text = "Сбросить";
            Cancel_B.UseVisualStyleBackColor = true;
            Cancel_B.Click += Cancel_B_Click;
            // 
            // Change_B
            // 
            Change_B.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Change_B.Location = new Point(327, 705);
            Change_B.Name = "Change_B";
            Change_B.Size = new Size(111, 43);
            Change_B.TabIndex = 2;
            Change_B.Text = "Изменить";
            Change_B.UseVisualStyleBackColor = true;
            Change_B.Click += Change_B_Click;
            // 
            // Delete_B
            // 
            Delete_B.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Delete_B.Location = new Point(444, 705);
            Delete_B.Name = "Delete_B";
            Delete_B.Size = new Size(111, 43);
            Delete_B.TabIndex = 3;
            Delete_B.Text = "Удалить";
            Delete_B.UseVisualStyleBackColor = true;
            Delete_B.Click += Delete_B_Click;
            // 
            // ChangeImg_B
            // 
            ChangeImg_B.Enabled = false;
            ChangeImg_B.Location = new Point(48, 269);
            ChangeImg_B.Name = "ChangeImg_B";
            ChangeImg_B.Size = new Size(75, 23);
            ChangeImg_B.TabIndex = 23;
            ChangeImg_B.Text = "Изменить";
            ChangeImg_B.UseVisualStyleBackColor = true;
            ChangeImg_B.Click += Order_Img_Click;
            // 
            // SaveImg_B
            // 
            SaveImg_B.Location = new Point(133, 269);
            SaveImg_B.Name = "SaveImg_B";
            SaveImg_B.Size = new Size(75, 23);
            SaveImg_B.TabIndex = 24;
            SaveImg_B.Text = "Скачать";
            SaveImg_B.UseVisualStyleBackColor = true;
            SaveImg_B.Click += SaveImg_B_Click;
            // 
            // DeleteImg_B
            // 
            DeleteImg_B.Enabled = false;
            DeleteImg_B.Location = new Point(214, 269);
            DeleteImg_B.Name = "DeleteImg_B";
            DeleteImg_B.Size = new Size(75, 23);
            DeleteImg_B.TabIndex = 25;
            DeleteImg_B.Text = "Удалить";
            DeleteImg_B.UseVisualStyleBackColor = true;
            DeleteImg_B.Click += DeleteImg_B_Click;

            Controls.Add(DeleteImg_B);
            Controls.Add(SaveImg_B);
            Controls.Add(ChangeImg_B);
            Controls.Add(Delete_B);
            Controls.Add(Change_B);
            Controls.Add(Cancel_B);
            Controls.Add(Save_B);

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
                    if (_order.ORD_ID != 0)
                        db.Entry(_order).State = EntityState.Modified;
                    else
                    {
                        _order.ORD_ST_ID = 5;
                        db.Entry(_order).State = EntityState.Added;
                    }

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

                    _portfolio.POR_ORD_ID = _order.ORD_ID == 0
                        ? db.Orders.Where(ord => ord.ORD_AC_Account_ID == artistId.AC_Account_ID).ToList().Last().ORD_ID
                        : _order.ORD_ID;

                    db.Entry(_portfolio).State = _portfolio.POR_ID != 0 ? EntityState.Modified : EntityState.Added;
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
            using (var db = new lab_OAIP_6_v1Entities())
            {
                OrderALogin_TB.Text = db.Accounts.First(account => account.AC_Account_ID == _order.ORD_AC_Account_ID)
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