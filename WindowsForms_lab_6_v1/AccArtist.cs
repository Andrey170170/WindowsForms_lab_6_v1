using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForms_lab_6_v1
{
    public partial class AccArtist : Form
    {
        private readonly Account _account;
        private readonly Artist _artist;

        public AccArtist()
        {
            InitializeComponent();
        }

        public AccArtist(Account userAccount)
        {
            InitializeComponent();
            _account = userAccount;
            using (var db = new lab_OAIP_6_v1Entities())
            {
                _artist = db.Artists.First(art => art.ART_AC_Account_ID == userAccount.AC_Account_ID);
                Login_TB.Text = userAccount.AC_Login;
                FullName_TB.Text = _artist.ART_FullName;
                Age_TB.Text = _artist.ART_Age.ToString();
                if (FullName_TB.Text == "" || Age_TB.Text == "0")
                {
                    Orders_P.Visible = false;
                    Profile_SpC.Panel2.Enabled = false;
                    Error_L.Text = "Заполните свои данные";
                }

                MyMethods.UpdateLV(_account, Portfolio_ImL, Portfolio_LV);
            }
        }

        private void Password_CB_CheckedChanged(object sender, EventArgs e)
        {
            Password_TB.UseSystemPasswordChar = Password_TB.UseSystemPasswordChar == false;
        }

        private void Cancel_B_Click(object sender, EventArgs e)
        {
            Login_TB.Text = _account.AC_Login;
            Password_TB.Text = "";
            FullName_TB.Text = _artist.ART_FullName;
            Age_TB.Text = _artist.ART_Age.ToString();
        }

        private void Save_B_Click(object sender, EventArgs e)
        {
            try
            {
                if (Login_TB.Text == "")
                {
                    throw new Exception("Login is empty");
                }

                if (FullName_TB.Text == "")
                {
                    throw new Exception("Введите свое имя");
                }

                if (Age_TB.Text == "0")
                {
                    throw new Exception("Введите свой возраст");
                }

                if (_account.AC_Login == Login_TB.Text && _account.AC_Password == Password_TB.Text &&
                    _artist.ART_FullName == FullName_TB.Text && _artist.ART_Age == int.Parse(Age_TB.Text)) return;
                using (var db = new lab_OAIP_6_v1Entities())
                {
                    _account.AC_Login = Login_TB.Text;
                    _account.AC_Password = Password_TB.Text != ""
                        ? MyMethods.GetHashString(Password_TB.Text.Trim())
                        : _account.AC_Password;
                    _artist.ART_FullName = FullName_TB.Text;
                    _artist.ART_Age = int.Parse(Age_TB.Text);
                    db.Entry(_artist).State = EntityState.Modified;
                    db.Entry(_account).State = EntityState.Modified;
                    db.SaveChanges();
                    Orders_P.Visible = true;
                    Profile_SpC.Panel2.Enabled = true;
                    Error_L.Text = "";
                    throw new Exception("Данные сохранены");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void AccArtist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Exit_B_Click(object sender, EventArgs e)
        {
            var signIn = new SignIn();
            this.Hide();
            signIn.Show();
        }

        private void Portfolio_LV_Click(object sender, EventArgs e)
        {
            var mousePos = Portfolio_LV.PointToClient(Control.MousePosition);
            var hitTest = Portfolio_LV.HitTest(mousePos);
            var orderEditing = new OrderEditing((Order) (hitTest.Item.Tag));
            orderEditing.Show();
        }

        private void Update_B_Click(object sender, EventArgs e)
        {
            MyMethods.UpdateLV(_account, Portfolio_ImL, Portfolio_LV);
        }

        private void Add_B_Click(object sender, EventArgs e)
        {
            var orderEditing = new OrderEditing(_account.AC_Account_ID);
            orderEditing.Show();
        }

        private void Orders_P_Enter(object sender, EventArgs e)
        {
            MyMethods.UpdateOrderLV(_account, Orders_LV);
            MyMethods.UpdateMyOrderLV(_account, MyOrder_LV);
        }

        private void Order_Update_B_Click(object sender, EventArgs e)
        {
            MyMethods.UpdateOrderLV(_account, Orders_LV);
        }

        private void MyOrder_Update_B_Click(object sender, EventArgs e)
        {
            MyMethods.UpdateMyOrderLV(_account, MyOrder_LV);
        }

        private void MyOrder_LV_Click(object sender, EventArgs e)
        {
            var mousePos = MyOrder_LV.PointToClient(Control.MousePosition);
            var hitTest = MyOrder_LV.HitTest(mousePos);
            var inProgressForm = new OrderInProgressForm((OrdersInProgress)(hitTest.Item.Tag));
            inProgressForm.Show();
        }

        private void Orders_LV_Click(object sender, EventArgs e)
        {
            var mousePos = Orders_LV.PointToClient(Control.MousePosition);
            var hitTest = Orders_LV.HitTest(mousePos);
            var previewOrder = new PreviewOrder((Order)(hitTest.Item.Tag), _account);
            previewOrder.Show();
        }
    }
}