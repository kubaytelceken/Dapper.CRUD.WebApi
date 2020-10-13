using Dapper.CRUD.WebApi.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper.CRUD.WebApi.Dao
{
    public class GetDao
    {
        public static IConfiguration conf = DBUtils.DBUtil.conf;
        public List<ProductModel> getProductsDao()
        {
            List<ProductModel> productModels = new List<ProductModel>();
            string query = @"SELECT * FROM ProductList";
            try
            {
                using (var connection = new SqlConnection(conf.GetConnectionString("DapperDB")))
                {
                    productModels = connection.Query<ProductModel>(query).ToList();
                }
            }
            catch (Exception)
            {
                productModels = null;
            }
            return productModels;
        }
    }
}
