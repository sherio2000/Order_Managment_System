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
    public partial class Edit_Product : Form
    {
        private ProductUtils productUtils = new ProductUtils();
        private Utils utils = new Utils();
        public Edit_Product()
        {
            InitializeComponent();
        }

        private void Edit_Product_Load(object sender, EventArgs e)
        {
            populateComboBox();
        }

        private void populateComboBox()
        {
            List<Product> products = productUtils.GetProducts(Variables.ProductsFilePath);
            foreach (Product product in products)
            {

                EditProductComboBx.Items.Add(product.ProductName);
            }
        }

        private void EditProductComboBx_SelectedValueChanged(object sender, EventArgs e)
        {
            if(EditProductComboBx.SelectedItem != null)
            {
                Product product = productUtils.GetProductByName(EditProductComboBx.SelectedItem.ToString(), Variables.ProductsFilePath);
                EditProductNameTxtBx.Text = product.ProductName;
                EditProductPriceTxtBx.Text = product.ProductPrice.ToString();
                EditProductDescTxtBx.Text = product.ProductDesc;
                EditProductRateTxtBx.Text = product.ProductRate.ToString();
            }
        }

        private void reloadFieldValues()
        {
            if (EditProductComboBx.SelectedItem != null)
            {
                Product product = productUtils.GetProductByName(EditProductComboBx.SelectedItem.ToString(), Variables.ProductsFilePath);
                EditProductNameTxtBx.Text = product.ProductName;
                EditProductPriceTxtBx.Text = product.ProductPrice.ToString();
                EditProductDescTxtBx.Text = product.ProductDesc;
                EditProductRateTxtBx.Text = product.ProductRate.ToString();
            }
        }

        private void EditProductBtn_Click(object sender, EventArgs e)
        {
            if(EditProductComboBx.SelectedItem != null)
            {
                if(EditProductNameTxtBx.Text != "")
                {
                    if(EditProductDescTxtBx.Text != "")
                    {
                        if(EditProductPriceTxtBx.Text != "")
                        {
                            if(int.TryParse(EditProductPriceTxtBx.Text, out int price))
                            {
                                if(price > 0)
                                {
                                    if(EditProductRateTxtBx.Text != "")
                                    {
                                        if(double.TryParse(EditProductRateTxtBx.Text, out double rate))
                                        {
                                            if(rate > 0)
                                            {
                                                Product updatedProducted = new Product();
                                                Product ProductId = productUtils.GetProductByName(EditProductComboBx.SelectedItem.ToString(), Variables.ProductsFilePath);
                                                updatedProducted.Id = ProductId.Id;
                                                updatedProducted.ProductName = EditProductNameTxtBx.Text;
                                                updatedProducted.ProductPrice = int.Parse(EditProductPriceTxtBx.Text);
                                                updatedProducted.ProductRate = double.Parse(EditProductRateTxtBx.Text);
                                                updatedProducted.ProductDesc = EditProductDescTxtBx.Text;
                                                productUtils.UpdateProduct(Variables.ProductsFilePath, updatedProducted);
                                                MessageBox.Show("Product Updated Successfully!", "Success");
                                                reloadFieldValues();
                                            } else
                                            {
                                                utils.ShowError("Error", "Please enter rate higher than 0!");
                                            }
                                        } else
                                        {
                                            utils.ShowError("Error", "Please enter valid double!");
                                        }
                                    } else
                                    {
                                        utils.ShowError("Error", "Please Enter Rate!");
                                    }
                                } else
                                {
                                    utils.ShowError("Error", "Please enter price greater than 0!");
                                }
                            } else
                            {
                                utils.ShowError("Error", "Please enter valid price!");
                            }
                        } else
                        {
                            utils.ShowError("Error", "Please enter price!");
                        }
                    } else
                    {
                        utils.ShowError("Error", "Please enter product description!");
                    }
                } else
                {
                    utils.ShowError("Error", "Please enter product name!");
                }
            } else
            {
                utils.ShowError("Error", "Please select product!");
            }
        }
    }
}
