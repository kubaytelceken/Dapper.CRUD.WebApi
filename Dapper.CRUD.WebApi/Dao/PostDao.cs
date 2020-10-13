using Dapper.CRUD.WebApi.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper.CRUD.WebApi.Dao
{
    public class PostDao
    {
        public static IConfiguration conf = DBUtils.DBUtil.conf;
        public int getStockNumber(string productName)
        {
            int returnValue = 0;
            string query = @"SELECT Product_StockNr FROM ProductList WHERE Product_Name='"+productName+"'";
            try
            {
                using (var connection = new SqlConnection(conf.GetConnectionString("DapperDB")))
                {
                    returnValue = connection.Query<int>(query).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                returnValue = 0;
            }
            return returnValue;
        }

        public bool saveProductDao(ProductModel productModel)
        {
            bool returnValue = false;
            string query = @"INSERT INTO ProductList (Product_Name,Product_Price,Product_StockNr) 
                            VALUES ('"+productModel.Product_Name+"','"+productModel.Product_Price+"','"+productModel.Product_StockNR+"')";
            try
            {
                using (var connection = new SqlConnection(conf.GetConnectionString("DapperDB")))
                {
                    connection.Execute(query);
                    returnValue = true;
                }
            }
            catch (Exception)
            {
                returnValue = false;
            }
            return returnValue;
        }

        public bool updateProductDao(int id,ProductModel productModel)
        {
            bool returnValue = false;
            string query = @"UPDATE ProductList SET Product_Name='"+productModel.Product_Name+"',Product_Price='"+productModel.Product_Price+"',Product_StockNr='"+productModel.Product_StockNR+"' WHERE Id='"+id+"'";
            try
            {
                using (var connection = new SqlConnection(conf.GetConnectionString("DapperDB")))
                {
                    connection.Execute(query);
                    returnValue = true;
                }
            }
            catch (Exception)
            {
                returnValue = false;
            }
            return returnValue;
        }

        public bool deleteProductDao(int id)
        {
            bool returnValue = false;
            string query = @"DELETE FROM ProductList WHERE Id='"+id+"'";
            try
            {
                using (var connection = new SqlConnection(conf.GetConnectionString("DapperDB")))
                {
                    connection.Execute(query);
                    returnValue = true;
                }
            }
            catch (Exception)
            {
                returnValue = false;
            }
            return returnValue;
        }
    }
}
