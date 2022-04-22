﻿using System;
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
    public partial class AccCustomer : Form
    {
        private Account _account;
        private Customer _customer;
        public AccCustomer()
        {
            InitializeComponent();
        }

        public AccCustomer(Account userAccount)
        {
            InitializeComponent();
            _account = userAccount;
            using (var db = new OAIP_6_v1Entities())
            {
                _customer = db.Customers.First(customer => customer.CUS_AC_Account_ID == userAccount.AC_Account_ID);
                Login_TB.Text = userAccount.AC_Login;
                Password_TB.Text = userAccount.AC_Password;
                FullName_TB.Text = _customer.CUS_FullName;
                Age_TB.Text = _customer.CUS_Age.ToString();
                if (FullName_TB.Text != "" && Age_TB.Text != "0") return;
                Orders_P.Visible = false;
                Error_L.Text = "Заполните свои данные";
            }
        }

        private void Password_CB_CheckedChanged(object sender, EventArgs e)
        {
            Password_TB.UseSystemPasswordChar = Password_TB.UseSystemPasswordChar == false;
        }

        private void Cancel_B_Click(object sender, EventArgs e)
        {
            Login_TB.Text = _account.AC_Login;
            Password_TB.Text = _account.AC_Password;
            FullName_TB.Text = _customer.CUS_FullName;
            Age_TB.Text = _customer.CUS_Age.ToString();
        }

        private void Save_B_Click(object sender, EventArgs e)
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
                if (FullName_TB.Text == "")
                {
                    throw new Exception("Введите свое имя");
                }
                if (Age_TB.Text == "0")
                {
                    throw new Exception("Введите свой возраст");
                }

                if (_account.AC_Login == Login_TB.Text && _account.AC_Password == Password_TB.Text &&
                    _customer.CUS_FullName == FullName_TB.Text && _customer.CUS_Age == int.Parse(Age_TB.Text)) return;
                using (var db = new OAIP_6_v1Entities())
                {
                    _account.AC_Login = Login_TB.Text;
                    //_account.AC_Password = MyHash.GetHashString(Password_TB.Text);
                    _customer.CUS_FullName = FullName_TB.Text;
                    _customer.CUS_Age = int.Parse(Age_TB.Text);
                    db.Entry(_customer).State = EntityState.Modified;
                    db.Entry(_account).State = EntityState.Modified;
                    db.SaveChanges();
                    Orders_P.Visible = true;
                    Error_L.Text = "";
                    throw new Exception("Данные сохранены");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void AccCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Exit_B_Click(object sender, EventArgs e)
        {
            var signIn = new SignIn();
            this.Hide();
            signIn.Show();
        }
    }
}