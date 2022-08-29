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
    public partial class Add_Product : Form
    {
        private ProductUtils productUtils = new ProductUtils();
        private Utils utils = new Utils();
        public Add_Product()
        {
            InitializeComponent();
        }

        private void clearInputs()
        {
            AddProductNameTxtBx.Text = "";
            AddProductDescTxtBx.Text = "";
            AddProductPriceTxtBx.Text = "";
            AddProductRateTxtBx.Text = "";
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            int productPrice;
            double productRate;
            if(AddProductNameTxtBx.Text != "")
            {
                if(AddProductDescTxtBx.Text != "")
                {
                    if(AddProductPriceTxtBx.Text != "")
                    {
                        if(int.TryParse(AddProductPriceTxtBx.Text, out productPrice))
                        {
                            if(productPrice > 0)
                            {
                                if(AddProductRateTxtBx.Text != "")
                                {
                                    if(double.TryParse(AddProductRateTxtBx.Text, out productRate))
                                    {
                                        if(productRate > 0)
                                        {
                                            Product newProduct = new Product(); 
                                            newProduct.ProductName = AddProductNameTxtBx.Text;
                                            newProduct.ProductDesc = AddProductDescTxtBx.Text;
                                            newProduct.ProductPrice = int.Parse(AddProductPriceTxtBx.Text);
                                            newProduct.ProductRate = double.Parse(AddProductRateTxtBx.Text);
                                            productUtils.AddProduct(newProduct, Variables.ProductsFilePath);
                                            MessageBox.Show("Product Added Successfully!", "Success!");
                                            clearInputs();
                                        } else
                                        {
                                            utils.ShowError("Error", "Enter value greater than 0 for product rate");
                                        }
                                    } else
                                    {
                                        utils.ShowError("Error", "Enter numeric value for product rate");
                                    }
                                } else
                                {
                                    utils.ShowError("Error", "Enter value for product rate");
                                }
                            } else
                            {
                                utils.ShowError("Error", "Enter value greater than 0 for product price");
                            }
                        } else
                        {
                            utils.ShowError("Error", "Enter numeric value for product price");
                        }
                    } else
                    {
                        utils.ShowError("Error", "Enter value for product price");
                    }
                } else
                {
                    utils.ShowError("Error", "Enter value for product description");
                }
            } else
            {
                utils.ShowError("Error", "Enter value for product name");
            }
        }
    }
}
