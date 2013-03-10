using BestBuyWebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyWebApi.Logics
{
    interface IProductDataProvider
    {
        IEnumerable<ProductInfo> GetMostInterestingProduct(string VendorName);

        IEnumerable<ProductInfo> GetProductByVendor(string VendorName);

        ProductInfo GetProduct(string productId);

    }
}
