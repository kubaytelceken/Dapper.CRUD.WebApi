using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper.CRUD.WebApi.Model
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Product_Name { get; set; }
        public int Product_Price { get; set; }
        public int Product_StockNR { get; set; }
    }
}
