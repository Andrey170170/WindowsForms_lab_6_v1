using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForms_lab_6_v1
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void ForgotPas_L_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_L_Click(object sender, EventArgs e)
        {
            var su = new SignUp();
            this.Hide();
            su.Show();
        }

        private void Password_CB_CheckedChanged(object sender, EventArgs e)
        {
            Password_TB.UseSystemPasswordChar = Password_TB.UseSystemPasswordChar == false;
        }

        private void SignIn_B_Click(object sender, EventArgs e)
        {
            try
            {
                if (Login_TB.Text.Trim() == "")
                {
                    throw new Exception("Login is empty");
                }

                if (Password_TB.Text.Trim() == "")
                {
                    throw new Exception("Password is empty");
                }

                using (var db = new lab_OAIP_6_v1Entities())
                {
                    var acc = db.Accounts.FirstOrDefault(account => account.AC_Login == Login_TB.Text.Trim());
                    if (acc != null)
                    {
                        if (MyMethods.GetHashString(Password_TB.Text.Trim()) == acc.AC_Password)
                        {
                            switch (acc.AC_Role)
                            {
                                case "Художник":
                                    var artist = new AccArtist(acc);
                                    this.Hide();
                                    artist.Show();
                                    return;
                                case "Заказчик":
                                    var customer = new AccCustomer(acc);
                                    this.Hide();
                                    customer.Show();
                                    return;
                                default:
                                    throw new Exception("ЭЭЭ ты меня сломал");
                            }
                        }
                        else
                        {
                            throw new Exception("Неправильный пароль");
                        }
                    }
                    else
                    {
                        throw new Exception("Логин не верен");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void SignInOrUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}