using System;
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
                if (Login_TB.Text == "")
                {
                    throw new Exception("Login is empty");
                }

                if (Password_TB.Text == "")
                {
                    throw new Exception("Password is empty");
                }

                using (OAIP_6_v1Entities db = new OAIP_6_v1Entities())
                {
                    foreach (var account in db.Accounts)
                    {
                        if (Login_TB.Text == account.AC_Login && MyHash.GetHashString(Password_TB.Text) == account.AC_Password)
                        {
                            switch (account.AC_Role)
                            {
                                case "Художник":
                                    var artist = new AccArtist(account);
                                    this.Hide();
                                    artist.Show();
                                    return; 
                                case "Заказчик":
                                    var customer = new AccCustomer(account);
                                    this.Hide();
                                    customer.Show();
                                    return;
                                default:
                                    throw new Exception("ЭЭЭ ты меня сломал");
                            }
                        }
                    }
                    throw new Exception("Пароль или Логин не верны");
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