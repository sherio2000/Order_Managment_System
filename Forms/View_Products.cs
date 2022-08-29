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
    public partial class View_Products : Form
    {
        private ProductUtils productUtils = new ProductUtils();
        private Utils utils = new Utils();
        public View_Products()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Products_Load(object sender, EventArgs e)
        {
            loadProductsData();
        }

        private void loadProductsData()
        {
            List<Product> products = productUtils.GetProducts(Variables.ProductsFilePath);
            for (int i = 0; i < products.Count; i++)
            {
                Product product = new Product();
                product.Id = products[i].Id;
                product.ProductName = products[i].ProductName;
                product.ProductDesc = products[i].ProductDesc;
                product.ProductPrice = products[i].ProductPrice;
                product.ProductRate = products[i].ProductRate;
                productBindingSource.Add(product);
            }
        }

        private void ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(ProductsDataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                if(MessageBox.Show("Are you sure you want to delete this record?", "Alert" ,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int val = (int)ProductsDataGridView.CurrentRow.Cells[0].Value;
                   productUtils.DeleteProduct(val, Variables.ProductsFilePath);
                   productBindingSource.RemoveCurrent();
                }
            }
        }

        private void loadProductData(Product product)
        {
            ProductsDataGridView.Rows.Clear();
            Product searchedProduct = new Product();
            searchedProduct.Id = product.Id;
            searchedProduct.ProductName = product.ProductName;
            searchedProduct.ProductDesc = product.ProductDesc;
            searchedProduct.ProductPrice = product.ProductPrice;
            searchedProduct.ProductRate = product.ProductRate;
            productBindingSource.Add(searchedProduct);
            ProductsDataGridView.Update();
            ProductsDataGridView.Refresh();
        }

        private void ViewProductsSrchBtn_Click(object sender, EventArgs e)
        {
            if(ViewProductIdTxtBx.Text != "")
            {
                int id;
                if(int.TryParse(ViewProductIdTxtBx.Text, out id))
                {
                    Product product = productUtils.GetProductById(int.Parse(ViewProductIdTxtBx.Text), Variables.ProductsFilePath);
                    if(product.Id != 0 && product.ProductName != null)
                    {
                        loadProductData(product);
                    } else
                    {
                        utils.ShowError("Invalid Id", "Enter Valid Product Id");
                    }

                } else
                {
                    utils.ShowError("Invalid Input", "Enter Valid Number!");
                }
            } else if(ViewProductNameTxtBx.Text != "")
            {
                Product product = productUtils.GetProductByName(ViewProductNameTxtBx.Text, Variables.ProductsFilePath);
                if (product.Id != 0 && product.ProductName != null)
                {
                    loadProductData(product);
                } else
                {
                    utils.ShowError("Invalid Name", "Enter valid Product Name");
                }
            } else if(ViewProductIdTxtBx.Text == "" && ViewProductNameTxtBx.Text == "")
            {
                utils.ShowError("Empty input!", "Kindly input Id or Name in fields");
            }
        }

        private void ViewProductsRldataBtn_Click(object sender, EventArgs e)
        {
            ProductsDataGridView.Rows.Clear();
            loadProductsData();
            ProductsDataGridView.Update();
            ProductsDataGridView.Refresh();
        }
    }
}
