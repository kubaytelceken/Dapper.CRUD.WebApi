using Dapper.CRUD.WebApi.Dao;
using Dapper.CRUD.WebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper.CRUD.WebApi.Services
{
    public class GetServices
    {
        GetDao getDao = new GetDao();
        public List<ProductModel> getProducts()
        {
            return getDao.getProductsDao();
        }
    }
}
