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
    public partial class View_Orders : Form
    {
        private OrderUtils orderUtils = new OrderUtils();
        private Utils utils = new Utils();
        public View_Orders()
        {
            InitializeComponent();
        }

        private void ViewOrdersRldataBtn_Click(object sender, EventArgs e)
        {
            OrdersDataGridView.Rows.Clear();
            loadOrdersData();
            OrdersDataGridView.Update();
            OrdersDataGridView.Refresh();
        }

        private void loadOrdersData()
        {
            List<Order> orders = orderUtils.GetAllOrders(Variables.ordersFilePath);
            for (int i = 0; i < orders.Count; i++)
            {
                Order order = new Order();
                order.Id = orders[i].Id;
                order.UserId = orders[i].UserId;
                order.OrderTotal = orders[i].OrderTotal;
                order.OrderStatus= orders[i].OrderStatus;
                orderBindingSource.Add(order);
            }
        }

        private void loadSearchedOrdersData(List<Order> searchedOrders)
        {
            OrdersDataGridView.Rows.Clear();
            List<Order> orders = searchedOrders;
            for (int i = 0; i < orders.Count; i++)
            {
                Order order = new Order();
                order.Id = orders[i].Id;
                order.UserId = orders[i].UserId;
                order.OrderTotal = orders[i].OrderTotal;
                order.OrderStatus = orders[i].OrderStatus;
                orderBindingSource.Add(order);
            }
        }

        private void View_Orders_Load(object sender, EventArgs e)
        {
            loadOrdersData();
        }


        private void loadOrderData(Order order)
        {
            OrdersDataGridView.Rows.Clear();
            Order searchedOrder = new Order();
            searchedOrder.Id = order.Id;
            searchedOrder.UserId = order.UserId;
            searchedOrder.OrderTotal = order.OrderTotal;
            searchedOrder.OrderStatus = order.OrderStatus;
            orderBindingSource.Add(searchedOrder);
            OrdersDataGridView.Update();
            OrdersDataGridView.Refresh();
        }

        private void ViewOrdersSrchBtn_Click(object sender, EventArgs e)
        {
            if (ViewOrderIdTxtBx.Text != "")
            {
                int id;
                if (int.TryParse(ViewOrderIdTxtBx.Text, out id))
                {
                    Order order = orderUtils.GetOrderById(int.Parse(ViewOrderIdTxtBx.Text), Variables.ordersFilePath);
                    if (order.OrderStatus != null)
                    {
                        loadOrderData(order);
                    }
                    else
                    {
                        utils.ShowError("Invalid Id", "Enter Valid Order Id");
                    }

                }
                else
                {
                    utils.ShowError("Invalid Input", "Enter Valid Number!");
                }
            } else if(orderStatusCmboBx.SelectedItem != null)
            {
                var status = orderStatusCmboBx.SelectedItem.ToString().ToLower();
                List<Order> order = orderUtils.GetOrdersByOrderStatus(Variables.ordersFilePath, status);
                if(order.Count > 0)
                {
                    loadSearchedOrdersData(order);
                } else
                {
                    utils.ShowError("Not Found!", "The status selected is not found");
                }
            }
            else if (ViewOrderIdTxtBx.Text == "" && orderStatusCmboBx.SelectedItem == null)
            {
                utils.ShowError("Empty input!", "Kindly input Id");
            }
        }

        private void OrdersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(OrdersDataGridView.Columns[e.ColumnIndex].Name == "ViewOrderDetails")
            {
                int val = (int)OrdersDataGridView.CurrentRow.Cells[0].Value;
                Order_Details order_Details = new Order_Details(val);
                order_Details.ShowDialog();
            } else if (OrdersDataGridView.Columns[e.ColumnIndex].Name == "ViewCustomer")
            {
                int val = (int)OrdersDataGridView.CurrentRow.Cells[1].Value;
                ViewCustomer customerDetails = new ViewCustomer(val);
                customerDetails.ShowDialog();
            } else if (OrdersDataGridView.Columns[e.ColumnIndex].Name == "updateStatus")
            {
                int val = (int)OrdersDataGridView.CurrentRow.Cells[0].Value;
                string status = OrdersDataGridView.CurrentRow.Cells[3].Value.ToString();
                Update_Order_Status editOrderStatus = new Update_Order_Status(val, status);          
                editOrderStatus.ShowDialog();
            }
        }
    }
}
