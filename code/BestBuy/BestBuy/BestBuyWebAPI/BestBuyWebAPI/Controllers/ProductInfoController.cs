using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BestBuyWebAPI.Logic;
using BestBuyWebAPI.Models; 
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace BestBuyWebAPI.Controllers
{
    public class ProductInfoController : ApiController
    {

        public IEnumerable<ProductInfo> GetAllProduct()
        {
            return new ProductInfoProvider().GetAllProduct(); 
        } 

        public IEnumerable<ProductInfo> GetProductByVendor(string VendorId)
        {
           return new ProductInfoProvider().GetProductByVendor(VendorId);
        }

        public IEnumerable<ProductInfo> GetProductByCategory(string CategoryId)
        {
            return new ProductInfoProvider().GetProductByCategory(CategoryId);
        }
    }
}
