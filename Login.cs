using Order_Management_System___OODJ.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Order_Management_System___OODJ
{
    public partial class LoginForm : Form
    {
        private UserUtils userUtil = new UserUtils();
        private Utils utils = new Utils(); 

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginPasswordLbl_Click(object sender, EventArgs e)
        {

        }

        private void LoginPasswordLbl_Click_1(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var email = LoginEmailTxtBx.Text;
            var password = LoginPasswordTxtBx.Text;

            if (utils.isEmailValid(email))
            {
                if (userUtil.IsUserExist(email, Variables.usersFilePath))
                {
                    var user = userUtil.Login(email, password, Variables.usersFilePath);
                    if (user != null)
                    {
                        if (userUtil.IsAdmin(user.Id, Variables.usersFilePath))
                        {
                            userUtil.LoggActiveUser(user, Variables.activeUsersFilePath);
                            AdminMain adminMain = new AdminMain();
                            this.Hide();
                            adminMain.Show();
                        }
                        else if (userUtil.IsCustomer(user.Id, Variables.usersFilePath))
                        {
                            userUtil.LoggActiveUser(user, Variables.activeUsersFilePath);
                            CustomerMain customerMain = new CustomerMain();
                            this.Hide();
                            customerMain.Show();
                        }
                    }
                    else
                    {
                        utils.ShowError("Invalid", "Invalid Email/Password!");
                    }
                }
                else
                {
                    utils.ShowError("Please Enter Correct Email Address", "User Doesn't Exist!");
                }
            } else
            {
                utils.ShowError("Please Enter Valid Email Address", "Invalid Email Address");
            }
        }

        private void LoginExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
