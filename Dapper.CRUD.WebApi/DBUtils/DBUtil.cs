using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper.CRUD.WebApi.DBUtils
{
    public class DBUtil
    {
        public static IConfiguration conf;
        public static SqlConnection getConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conf.GetConnectionString("DapperDB").ToString();
            connection.Open();
            return connection;
        }
    }
}
