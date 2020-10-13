using Dapper.CRUD.WebApi.Dao;
using Dapper.CRUD.WebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper.CRUD.WebApi.Services
{
    public class PostServices
    {
        PostDao postDao = new PostDao();
        public int getStockNumberOfProduct(string productName)
        {
            return postDao.getStockNumber(productName);
        }

        public bool saveProductDB(ProductModel productModel)
        {
            return postDao.saveProductDao(productModel);
        }

        public bool updateProductDB(int id,ProductModel productModel)
        {
            return postDao.updateProductDao(id,productModel);
        }

        public bool deleteProductDB(int id)
        {
            return postDao.deleteProductDao(id);
        }
    }
}
