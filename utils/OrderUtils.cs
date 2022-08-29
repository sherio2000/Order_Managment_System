using Order_Management_System___OODJ.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Order_Management_System___OODJ.utils
{
    internal class OrderUtils
    {
        private Utils Utils = new Utils();
        private ProductUtils ProductUtils = new ProductUtils();
        public List<Order> GetAllOrders(string orderFilePath)
        {
            List<Order> orders = new List<Order>();
            List<string> lines = Utils.ReadLinesFromTextFile(orderFilePath);

            foreach (string line in lines)
            {
                string[] enteries = line.Split(',');
                Order order = new Order();
                order.Id = int.Parse(enteries[0]);
                order.UserId = int.Parse(enteries[1]);
                order.OrderStatus = enteries[2];
                order.OrderTotal = decimal.Parse(enteries[3]);
                orders.Add(order);
            }
            return orders;
        }

        public Order GetOrderById(int id, string orderFilePath)
        {
            Order order = new Order();
            List<string> lines = Utils.ReadLinesFromTextFile(orderFilePath);

            foreach (string line in lines)
            {
                string[] enteries = line.Split(',');
                if(enteries[0] == id.ToString())
                {
                    order.Id = int.Parse(enteries[0]);
                    order.UserId = int.Parse(enteries[1]);
                    order.OrderStatus = enteries[2];
                    order.OrderTotal = decimal.Parse(enteries[3]);
                }
            }
            return order;

        }

        public void UpdateOrderStatus(string status, int orderId , string OrderFilePath, string orderItemsFilePath)
        {
            Order orderToUpdate = new Order();
            List<string> lines = Utils.ReadLinesFromTextFile(OrderFilePath);
            List<Order> orders = GetAllOrders(OrderFilePath);

            foreach (string line in lines)
            {
                string[] enteries = line.Split(',');
                if (enteries[0] == orderId.ToString())
                {
                    orderToUpdate.Id = int.Parse(enteries[0]);
                    orderToUpdate.UserId = int.Parse(enteries[1]);
                    orderToUpdate.OrderStatus = status;
                    orderToUpdate.OrderTotal = decimal.Parse(enteries[3]);
                }
            }
            orders.RemoveAll(x => x.Id == orderId);
            orders.Add(orderToUpdate);
            Utils.DeleteAllLines(OrderFilePath);
            string[] output = new string[orders.Count];

            for (int i = 0; i < orders.Count; i++)
            {
                output[i] = orders[i].Id.ToString() + "," + orders[i].UserId + ","  + orders[i].OrderStatus + "," + orders[i].OrderTotal.ToString();
            }


            File.WriteAllLines(OrderFilePath, output);
        }

        public List<OrderItem> GetOrderItemsByOrderId(string filePath, int id)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            List<string> lines = Utils.ReadLinesFromTextFile(filePath);

            foreach (string line in lines)
            {
                string[] enteries = line.Split(',');
                if (enteries[1] == id.ToString())
                {
                    OrderItem orderItem = new OrderItem();
                    orderItem.Id = int.Parse(enteries[0]);
                    orderItem.OrderId = int.Parse(enteries[1]);
                    orderItem.ProductId = int.Parse(enteries[2]);
                    orderItem.UserId = int.Parse(enteries[3]);
                    orderItems.Add(orderItem);
                }
            }
            return orderItems;
        }

        public List<Order> GetOrdersByOrderStatus(string filePath, string status)
        {
            List<Order> orders = new List<Order>();
            List<string> lines = Utils.ReadLinesFromTextFile(filePath);

            foreach(string line in lines)
            {
                string[] enteries = line.Split(',');
                if (enteries[2] == status.ToLower())
                {
                    Order order = new Order();
                    order.Id = int.Parse(enteries[0]);
                    order.UserId = int.Parse(enteries[1]);
                    order.OrderStatus = enteries[2];
                    order.OrderTotal = int.Parse(enteries[3]);
                    orders.Add(order);
                }
            }
            return orders;
        }

        public decimal GetOrderTotalPrice(int id, string orderItemsFilePath, string productFilePath)
        {
            List<OrderItem> orderItems = GetOrderItemsByOrderId(orderItemsFilePath, id);
            decimal totalPrice = 0;
            foreach (var orderItem in orderItems)
            {
                totalPrice += ProductUtils.GetProductPriceById(orderItem.ProductId, productFilePath);
            }
            return totalPrice;
        }
    }
}
