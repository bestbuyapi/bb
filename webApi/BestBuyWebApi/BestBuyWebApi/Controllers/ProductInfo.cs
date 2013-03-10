using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BestBuyWebApi.Controllers
{
    public class ProductInfo
    {
    
        public string VendorName { get; set; }
        public int ProductId { get; set; }
        public string ProductTitle { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImage { get; set; }
        public decimal ProductNormalPrice { get; set; }
        public decimal ProductPromotionPrice { get; set; }
        public string ProductUnitType { get; set; }
    }

}
