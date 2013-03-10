using BestBuyWebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BestBuyWebApi.Logics
{
    public class ProductDataProvider : IProductDataProvider
    {

        public IEnumerable<ProductInfo> GetMostInterestingProduct(string VendorName)
        {
            return generateFakeData();
        }

        public IEnumerable<Controllers.ProductInfo> GetProductByVendor(string VendorName)
        {
            return generateFakeData();
        }

        public Controllers.ProductInfo GetProduct(string ProductId)
        {
            return generateFakeData().FirstOrDefault();
        }


        private IEnumerable<ProductInfo> generateFakeData()
        {
            List<ProductInfo> list = new List<ProductInfo>();
            list.Add(new ProductInfo()
            {
                ProductId  = 1,
                ProductTitle = "Product Detail",
                ProductDescription = "Product Description",
                ProductImage = "images/v.jpg",
                ProductNormalPrice = 2.00m,
                ProductPromotionPrice = 1.99m,
                VendorName = "Giant"
            });


            list.Add(new ProductInfo()
            {
                ProductId = 2,
                ProductTitle = "Product Detail1",
                ProductDescription = "Product Description1",
                ProductImage = "images/t.jpg",
                ProductNormalPrice = 12.00m,
                ProductPromotionPrice = 11.99m,
                VendorName = "Giant"
            });
            
            return list;
        }
    }
}