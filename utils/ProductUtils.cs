using Order_Management_System___OODJ.models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Order_Management_System___OODJ.utils
{
    internal class ProductUtils
    {
        private static Utils utils = new Utils();
        public void AddProduct(Product product, string filePath)
        {
            //Product newProduct = new Product();
            List<Product> products = GetProducts(filePath);
            int max_id = 0;
            if (products != null)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].Id > max_id)
                    {
                        max_id = products[i].Id;
                    }
                }
                max_id++;
            }
            string data = max_id + "," + product.ProductName + "," + product.ProductDesc + "," + product.ProductPrice.ToString() + "," + product.ProductRate.ToString();
            utils.WriteLineToTxtFile(filePath, data);
        }

        public decimal GetProductPriceById(int id, string filePath)
        {
            List<string> lines = utils.ReadLinesFromTextFile(filePath);
            Product product = new Product();
            foreach (string line in lines)
            {
                string[] enteries = line.Split(',');
                if (enteries[0] == id.ToString())
                {
                    return decimal.Parse(enteries[3]);
                }
            }
            return 0;
        }

        public Product GetProductById(int id, string filePath)
        {
            List<string> lines = utils.ReadLinesFromTextFile(filePath);
            Product product = new Product();
            foreach (string line in lines)
            {
                string[] enteries = line.Split(',');
                if (enteries[0] == id.ToString())
                {
                    product.Id = int.Parse(enteries[0]);
                    product.ProductName = enteries[1];
                    product.ProductDesc = enteries[2];
                    product.ProductPrice = decimal.Parse(enteries[3]);
                    product.ProductRate = double.Parse(enteries[4]);
                }
            }
            if(product != null)
            {
                return product;
            }
            return null;
        }

        public Product GetProductByName(string name, string filePath)
        {
            List<string> lines = utils.ReadLinesFromTextFile(filePath);
            Product product = new Product();
            foreach (string line in lines)
            {
                string[] enteries = line.Split(',');
                if (enteries[1] == name)
                {
                    product.Id = int.Parse(enteries[0]);
                    product.ProductName = enteries[1];
                    product.ProductDesc = enteries[2];
                    product.ProductPrice = decimal.Parse(enteries[3]);
                    product.ProductRate = double.Parse(enteries[4]);
                }
            }
            if (product != null)
            {
                return product;
            }
            return null;
        }

        public List<Product> GetProducts(string filePath)
        {
            List<Product> products = new List<Product>();
            List<string> lines = utils.ReadLinesFromTextFile(filePath);

            foreach (string line in lines)
            {
                string[] enteries = line.Split(',');
                Product product = new Product();
                product.Id = int.Parse(enteries[0]);
                product.ProductName = enteries[1];
                product.ProductDesc = enteries[2];
                product.ProductPrice = decimal.Parse(enteries[3]);
                product.ProductRate = double.Parse(enteries[4]);
                products.Add(product);
            }
            return products;
        }

        public void DeleteProduct(int id, string filePath)
        {
            List<Product> products = GetProducts(filePath);
            products.RemoveAll(x => x.Id == id);
            string[] output = new string[products.Count];

            for (int i = 0; i < products.Count; i++)
            {
                output[i] = products[i].Id.ToString() + "," + products[i].ProductName + "," + products[i].ProductDesc + "," + products[i].ProductPrice.ToString() + "," + products[i].ProductRate.ToString();
            }
            utils.DeleteAllLines(filePath);
            File.WriteAllLines(filePath, output);
        }
        public void UpdateProduct(string filePath, Product product)
        {
            Product productToUpdate = new Product();
            List<Product> products = GetProducts(filePath);
            productToUpdate.Id = product.Id;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.ProductDesc = product.ProductDesc;
            productToUpdate.ProductPrice = product.ProductPrice;
            productToUpdate.ProductRate = product.ProductRate;
            products.RemoveAll(x => x.Id == product.Id);
            products.Add(productToUpdate);
            utils.DeleteAllLines(filePath);
            string[] output = new string[products.Count]; ;

            for (int i = 0; i < products.Count; i++)
            {
                output[i] = products[i].Id.ToString() + "," + products[i].ProductName + "," + products[i].ProductDesc + "," + products[i].ProductPrice.ToString() + "," + products[i].ProductRate.ToString();
            }


            File.WriteAllLines(filePath, output);

        }
    }
}
