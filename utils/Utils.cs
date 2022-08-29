using Order_Management_System___OODJ.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Order_Management_System___OODJ.utils
{
    public class Utils
    {
        private UserUtils userUtils = new UserUtils();
        private ProductUtils productUtils = new ProductUtils();
        private static OrderUtils orderUtils = new OrderUtils();

        public void WriteLineToTxtFile(string filePath, string data)
        {
            File.AppendAllText(filePath, data + Environment.NewLine);
        }

        public List<String> ReadLinesFromTextFile(string path)
        {
            List<String> lines = File.ReadAllLines(path).ToList();
            return lines;
        }

        public void DeleteAllLines(string filePath)
        {
            File.WriteAllText(filePath, String.Empty);
        }

        public void ShowError(string errorMsg, string errorTitle)
        {
            MessageBox.Show(errorTitle, errorMsg, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool isEmailValid(string email)
        {
            if (email != null)
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if(match.Success)
                {
                    return true;
                }
            }
            return false;
        }

        public void seedAdminUserData()
        {
            if(!userUtils.IsUserExist("admin@gmail.com", Variables.usersFilePath))
            {
                string data = "0" + "," + "harpret shah" + "," + "admin123" + "," + "admin@gmail.com" + "," + "Admin" + "," + "Admin";
                WriteLineToTxtFile(Variables.usersFilePath, data);
            }
            if(!userUtils.IsUserExist("test@gmail.com", Variables.usersFilePath))
            {
                string data1 = "1" + "," + "Jake Paul" + "," + "test123" + "," + "test@gmail.com" + "," + "Jake2000" + "," + "Customer";
                WriteLineToTxtFile(Variables.usersFilePath, data1);
            }
        }

        public void seedProductsData()
        {
            if(productUtils.GetProducts(Variables.ProductsFilePath).Count < 1)
            {
                DeleteAllLines(Variables.ProductsFilePath);
                Product product1 = new Product() { Id = 0, ProductName = "Lenovo Legion Y520", ProductDesc = "16GB RAM - GTX GeForce 1050 - Core i7 - 2.8 GHZ - 1TB Storage", ProductPrice = 5200, ProductRate = 4.5 };
                Product product2 = new Product() { Id = 1, ProductName = "Hard Disk 1TB", ProductDesc = "1TB External Storage Hard disk", ProductPrice = 150, ProductRate = 3.5 };
                Product product3 = new Product() { Id = 2, ProductName = "Hard Disk 2TB", ProductDesc = "2TB External Storage Hard disk", ProductPrice = 250, ProductRate = 5 };
                Product product4 = new Product() { Id = 3, ProductName = "SpeedLink Gaming Mouse", ProductDesc = "Red Gaming Mouse 6 buttons Speedlink", ProductPrice = 60, ProductRate = 5 };
                Product product5 = new Product() { Id = 4, ProductName = "SpeedLink Gaming Keyboard", ProductDesc = "Gaming Keyboard With builtin led lights", ProductPrice = 40, ProductRate = 3 };
                productUtils.AddProduct(product1, Variables.ProductsFilePath);
                productUtils.AddProduct(product2, Variables.ProductsFilePath);
                productUtils.AddProduct(product3, Variables.ProductsFilePath);
                productUtils.AddProduct(product4, Variables.ProductsFilePath);
                productUtils.AddProduct(product5, Variables.ProductsFilePath);
            }
        }

        public void seedOrdersData()
        {
            // TODO
            if(orderUtils.GetAllOrders(Variables.ordersFilePath).Count < 1)
            {
                DeleteAllLines(Variables.ordersFilePath);
                DeleteAllLines(Variables.orderItemsFilePath);

                string data1 = "0" + "," + "1" + "," + "pending" + "," + "50";
                string data2 = "1" + "," + "1" + "," + "accepted" + "," + "30";
                string data3 = "2" + "," + "1" + "," + "rejected" + "," + "250";
                string data4 = "3" + "," + "1" + "," + "cancelled" + "," + "150";

                //order items for order id 0
                string dataItems1 = "0" + "," + "0" + "," + "2" + "," + "1";
                string dataItems2 = "1" + "," + "0" + "," + "1" + "," + "1";
                string dataItems3 = "2" + "," + "0" + "," + "3" + "," + "1";

                //order items for order id 1
                string dataItems4 = "3" + "," + "1" + "," + "4" + "," + "1";
                string dataItems5 = "4" + "," + "1" + "," + "1" + "," + "1";
                string dataItems6 = "5" + "," + "1" + "," + "2" + "," + "1";

                //order items for order id 2
                string dataItems7 = "6" + "," + "2" + "," + "5" + "," + "1";


                //order items for order id 3
                string dataItems8 = "7" + "," + "3" + "," + "1" + "," + "1";
                string dataItems9 = "8" + "," + "3" + "," + "2" + "," + "1";



                WriteLineToTxtFile(Variables.ordersFilePath, data1);
                WriteLineToTxtFile(Variables.ordersFilePath, data2);
                WriteLineToTxtFile(Variables.ordersFilePath, data3);
                WriteLineToTxtFile(Variables.ordersFilePath, data4);

                WriteLineToTxtFile(Variables.orderItemsFilePath, dataItems1);
                WriteLineToTxtFile(Variables.orderItemsFilePath, dataItems2);
                WriteLineToTxtFile(Variables.orderItemsFilePath, dataItems3);
                WriteLineToTxtFile(Variables.orderItemsFilePath, dataItems4);
                WriteLineToTxtFile(Variables.orderItemsFilePath, dataItems5);
                WriteLineToTxtFile(Variables.orderItemsFilePath, dataItems6);
                WriteLineToTxtFile(Variables.orderItemsFilePath, dataItems7);
                WriteLineToTxtFile(Variables.orderItemsFilePath, dataItems8);
                WriteLineToTxtFile(Variables.orderItemsFilePath, dataItems9);
            }
        }




    }
}
