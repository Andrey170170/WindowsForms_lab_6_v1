using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_lab_6_v1
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            Role_CB.Items.Add("Художник");
            Role_CB.Items.Add("Заказчик");
        }

        private void SignUp_B_Click(object sender, EventArgs e)
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
                if (Password_TB.Text != RepeatPassword_TB.Text)
                {
                    throw new Exception("Passwords do not match");
                }
                if (Role_CB.SelectedIndex == -1)
                {
                    throw new Exception("Chose your role");
                }
                using (OAIP_6_v1Entities db = new OAIP_6_v1Entities())
                {
                    if (db.Accounts.Count(account => account.AC_Login == Login_TB.Text) != 0)
                    {
                        throw new Exception("Пользователь с таким логином уже существует");
                    }
                    db.Accounts.Add(new Account(
                        Login_TB.Text,
                        MyMethods.GetHashString(Password_TB.Text),
                        Role_CB.SelectedItem.ToString()));
                    db.SaveChanges();
                    MessageBox.Show($"User {Login_TB.Text} registered successfully");
                    var signIn = new SignIn();
                    this.Hide();
                    signIn.Show();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Password_CB_CheckedChanged(object sender, EventArgs e)
        {
            Password_TB.UseSystemPasswordChar = Password_TB.UseSystemPasswordChar == false;
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            var signInOrUp = new SignIn();
            this.Hide();
            signInOrUp.Show();
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RepeatedPassword_ChB_CheckedChanged(object sender, EventArgs e)
        {
            RepeatPassword_TB.UseSystemPasswordChar = RepeatPassword_TB.UseSystemPasswordChar == false;
        }
    }
}
