using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;

using System.Text;

using ProductsEntityModel;
using System.ServiceModel.Activation;


namespace Products
{
    // WCF service that implements the service contract
    // This implementation performs minimal error checking and exception handling
    [AspNetCompatibilityRequirements(
    RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ProductsService : IProductsService
    {
        public List<ProductData> ListProducts()
        {
            // Create a list of products
            List<ProductData> productsList = new List<ProductData>();
            try
            {
                // Connect to the ProductsModel database
                using (ProductsModel database = new ProductsModel())
                {
                    List<Product> products = (from product in database.Products
                                              select product).ToList();
                    foreach (Product product in products)
                    {
                        ProductData productData = new ProductData()
                        {
                            NumeroProduto = product.NumeroProduto,
                            NameProduto = product.NameProduto,
                            DescricaoProduto = product.NameProduto,
                            EstoqueProduto = product.EstoqueProduto
                        };
                        productsList.Add(productData);
                    }
                }
            }
            catch
            {
            }
            return productsList;
        }



        public ProductData GetProduct(string numeroProduto)
        {
            ProductData productData = null;
            try
            {
                // Connect to the ProductsModel database
                using (ProductsModel database = new ProductsModel())
                {
                    // Find the first product that matches the specified product code
                    Product matchingProduct = database.Products.First(
                    p => String.Compare(p.NumeroProduto, numeroProduto) == 0);
                    productData = new ProductData()
                    {
                        NumeroProduto = matchingProduct.NumeroProduto,
                        NameProduto = matchingProduct.NameProduto,
                        DescricaoProduto = matchingProduct.NameProduto,
                        EstoqueProduto = matchingProduct.EstoqueProduto
                    };
                }
            }
            catch
            {
            }
            // Return the product
            return productData;
        }



        public int CurrentStockProduto(string numeroProduto)
        {
            int quantityTotal = 0;
            try
            {
                // Connect to the ProductsModel database
                using (ProductsModel database = new ProductsModel())
                {
                    // Calculate the sum of all quantities for the specified product
                    quantityTotal = (from p in database.Products
                                     where String.Compare(p.NumeroProduto, numeroProduto) == 0
                                     select (int)p.EstoqueProduto).Sum();
                }
            }
            catch
            {

            }
            return quantityTotal;
        }


        public bool AddStockProduto(string numeroProduto, int quantity)
        {
            ProductData productData = null;

            try
            {
                // Connect to the ProductsModel database
                using (ProductsModel database = new ProductsModel())
                {
                    Product matchingProduct = database.Products.First(
                    p => String.Compare(p.NumeroProduto, numeroProduto) == 0);
                    productData = new ProductData()
                    {
                        NumeroProduto = matchingProduct.NumeroProduto,
                        NameProduto = matchingProduct.NameProduto,
                        DescricaoProduto = matchingProduct.NameProduto,
                        EstoqueProduto = matchingProduct.EstoqueProduto
                    };

                    productData.EstoqueProduto = quantity;
                    database.Products.Add(matchingProduct);

                    database.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
