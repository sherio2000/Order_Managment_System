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
    public partial class Update_Order_Status : Form
    {
        private int orderId;
        private string orderStatus;
        private OrderUtils orderUtils = new OrderUtils();
        private Utils utils = new Utils();
        public Update_Order_Status(int id, string orderStatus)
        {
            InitializeComponent();
            this.orderId = id;
            this.orderStatus = orderStatus;
        }

        private void Update_Order_Status_Load(object sender, EventArgs e)
        {
            UpdateOrderStatusCurrentStatusLbl.Text = orderStatus;
        }

        private void UpdateOrderStatusBtn_Click(object sender, EventArgs e)
        {
            if(UpdateOrderStsCmboBx.SelectedItem != null)
            {
                orderUtils.UpdateOrderStatus(UpdateOrderStsCmboBx.SelectedItem.ToString().ToLower(), orderId, Variables.ordersFilePath, Variables.orderItemsFilePath);
                MessageBox.Show("Order Status Updated Successfully", "Success!");
                Order order = orderUtils.GetOrderById(orderId, Variables.ordersFilePath);
                UpdateOrderStatusCurrentStatusLbl.Text = order.OrderStatus;
            } else
            {
                utils.ShowError("Error", "Please Select Status");
            }
        }
    }
}
