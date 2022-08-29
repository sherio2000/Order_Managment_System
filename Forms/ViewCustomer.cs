using Order_Management_System___OODJ.models;
using Order_Management_System___OODJ.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Order_Management_System___OODJ.Forms
{
    public partial class ViewCustomer : Form
    {
        private int customerId;
        private UserUtils userUtils = new UserUtils();
        public ViewCustomer(int id)
        {
            InitializeComponent();
            this.customerId = id;
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            Users user = userUtils.GetUserById(customerId, Variables.usersFilePath);
            ViewCustomerFullNameLbl.Text = user.UserFullName;
            ViewCustomerEmailAddressLbl.Text = user.UserEmail;
            ViewCustomerUserNameLbl.Text = user.UserName;
        }
    }
}
