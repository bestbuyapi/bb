using BestBuyWebApi.Logics;
using BestBuyWebAPI.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BestBuyWebApi.Controllers
{
    public class ProductInfoController : ApiController
    {
        ProductDataProvider provider = new ProductDataProvider();
        
        public IEnumerable<ProductInfo> GetMostInterestingProduct()
        {
            return new ProductInfoProvider().GetAllProduct(); 
        }

        public IEnumerable<ProductInfo> GetProductByVendor(string VendorName)
        {
            return new ProductInfoProvider().GetProductByVendor(VendorName);
        }
        
        public ProductInfo GetProduct(string productId)
        {
            return new ProductInfoProvider().GetProduct(int.Parse(productId)).FirstOrDefault();
        }

        public IEnumerable<ProductInfo> GetProductByCategory(string CategoryId)
        {
            return new ProductInfoProvider().GetProductByCategory(CategoryId);
        }

    }
}
