using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient; 
using SYNDES.Lib.Common;  
using System.Text;

using BestBuyWebApi.Controllers;
using System.Configuration;

namespace BestBuyWebAPI.Logic
{
    public class ProductInfoProvider : Data
    {
        static string cnnString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        MySqlConnection cnx = new MySqlConnection(cnnString);

        public List<ProductInfo> GetAllProduct()
        {
            var list = new List<ProductInfo>();
            var da = new MySqlDataAdapter();
            var ds = new DataSet();
            var dt = new DataTable();

            string cmdText = "SELECT itemId, itemName, itemDesc, itemImagePath, normalPrice, promotionPrice, itemUnit ";
            cmdText = cmdText + "FROM sa_item WHERE itemStatus='Y'";
            var cmd = new MySqlCommand(cmdText, cnx);
            da.SelectCommand = cmd;
            da.Fill(ds);

            if (ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
            }

            foreach (DataRow row in dt.Rows)
            {
                var products = new ProductInfo()
                {
                    ProductId = (int)GetRowValue(row, "itemId"),
                    ProductTitle = (string)GetRowValue(row, "itemName"),
                    ProductDescription = (string)GetRowValue(row, "itemDesc"),
                    ProductImage = (string)GetRowValue(row, "itemImagePath"),
                    ProductNormalPrice = (decimal)GetRowValue(row, "normalPrice"),
                    ProductPromotionPrice = (decimal)GetRowValue(row, "promotionPrice"),
                    ProductUnitType = (string)GetRowValue(row, "itemUnit")
                };

                list.Add(products);
            }
            return list;
        }


        public List<ProductInfo> GetProductByVendor(string VendorId)
        {
            var list = new List<ProductInfo>();
            var da = new MySqlDataAdapter();
            var ds = new DataSet();
            var dt = new DataTable();

            string cmdText = "SELECT itemId, itemName, itemDesc, itemImagePath, normalPrice, promotionPrice, itemUnit ";
            cmdText = cmdText + "FROM sa_item WHERE itemStatus='Y' AND companyCode='" + VendorId + "'";
            var cmd = new MySqlCommand(cmdText, cnx);
            da.SelectCommand = cmd;
            da.Fill(ds);

            if (ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
            }

            foreach (DataRow row in dt.Rows)
            {
                var products = new ProductInfo()
                {
                    ProductId = (int)GetRowValue(row, "itemId"),
                    ProductTitle = (string)GetRowValue(row, "itemName"),
                    ProductDescription = (string)GetRowValue(row, "itemDesc"),
                    ProductImage = (string)GetRowValue(row, "itemImagePath"),
                    ProductNormalPrice = (decimal)GetRowValue(row, "normalPrice"),
                    ProductPromotionPrice = (decimal)GetRowValue(row, "promotionPrice"),
                    ProductUnitType = (string)GetRowValue(row, "itemUnit")
                };

                list.Add(products);
            }
            return list;
        }

        

        public List<ProductInfo> GetProduct(int productId)
        { 
            var list = new List<ProductInfo>();
            var da = new MySqlDataAdapter();
            var ds = new DataSet();
            var dt = new DataTable();

            string cmdText = "SELECT itemId, itemName, itemDesc, itemImagePath, normalPrice, promotionPrice, itemUnit ";
            cmdText = cmdText + "FROM sa_item WHERE itemStatus='Y' AND itemId='" + productId + "'";

            var cmd = new MySqlCommand(cmdText, cnx); 
            da.SelectCommand = cmd;
            da.Fill(ds); 

            if (ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
            }
             
            foreach (DataRow row in dt.Rows)
            {
                var products = new ProductInfo()
                {
                    ProductId = (int)GetRowValue(row, "itemId"),
                    ProductTitle = (string)GetRowValue(row, "itemName"),
                    ProductDescription = (string)GetRowValue(row, "itemDesc"),
                    ProductImage = (string)GetRowValue(row, "itemImagePath"),
                    ProductNormalPrice = (decimal)GetRowValue(row, "normalPrice"),
                    ProductPromotionPrice = (decimal)GetRowValue(row, "promotionPrice"),
                    ProductUnitType = (string)GetRowValue(row, "itemUnit") 
                };

                list.Add(products); 
            } 
            return list;

        }

        public List<ProductInfo> GetProductByCategory(string categoryId)
        {
            var list = new List<ProductInfo>();
            var da = new MySqlDataAdapter();
            var ds = new DataSet();
            var dt = new DataTable();

            string cmdText = "SELECT itemId, itemName, itemDesc, itemImagePath, normalPrice, promotionPrice, itemUnit ";
            cmdText = cmdText + "FROM sa_item WHERE itemStatus='Y' AND categoryCode='" + categoryId + "'";
            var cmd = new MySqlCommand(cmdText, cnx);
            da.SelectCommand = cmd;
            da.Fill(ds);

            if (ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
            }

            foreach (DataRow row in dt.Rows)
            {
                var products = new ProductInfo()
                {
                    ProductId = (int)GetRowValue(row, "itemId"),
                    ProductTitle = (string)GetRowValue(row, "itemName"),
                    ProductDescription = (string)GetRowValue(row, "itemDesc"),
                    ProductImage = (string)GetRowValue(row, "itemImagePath"),
                    ProductNormalPrice = (decimal)GetRowValue(row, "normalPrice"),
                    ProductPromotionPrice = (decimal)GetRowValue(row, "promotionPrice"),
                    ProductUnitType = (string)GetRowValue(row, "itemUnit")
                };

                list.Add(products);
            }
            return list;
        }
    }
}