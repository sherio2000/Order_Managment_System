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
    public partial class Order_Details : Form
    {
        private int orderID;
        private OrderUtils orderUtils = new OrderUtils();
        private ProductUtils productUtils = new ProductUtils();
        public Order_Details(int id)
        {
            InitializeComponent();
            this.orderID = id;
        }

        private void Order_Details_Load(object sender, EventArgs e)
        {
            //268, 111
            //268, 165
            int x = 268;
            int y = 111;
            List<OrderItem> orderItems = orderUtils.GetOrderItemsByOrderId(Variables.orderItemsFilePath, orderID);
            List<Label> labels = new List<Label>();
            for(int i = 0; i < orderItems.Count; i++)
            {                
                Product product = productUtils.GetProductById(orderItems[i].ProductId, Variables.ProductsFilePath);
                string productName = "Product Name : " + product.ProductName;
                string productDescription = "Product Description :" + product.ProductDesc;
                string productPrice = "Product Price : " + product.ProductPrice.ToString();
                string productRate = "Product Rate : " + product.ProductRate.ToString();
                orderItemsRichTextBox.AppendText("\r\n" + "ORDER ITEM");
                orderItemsRichTextBox.AppendText("\r\n" + "");
                orderItemsRichTextBox.AppendText("\r\n" + productName);
                orderItemsRichTextBox.AppendText("\r\n" + productDescription);
                orderItemsRichTextBox.AppendText("\r\n" + productPrice);
                orderItemsRichTextBox.AppendText("\r\n" + productRate);
                orderItemsRichTextBox.AppendText("\r\n" + "");
                orderItemsRichTextBox.AppendText("\r\n" + "");
                orderItemsRichTextBox.ScrollToCaret();

            }
        }
    }
}
