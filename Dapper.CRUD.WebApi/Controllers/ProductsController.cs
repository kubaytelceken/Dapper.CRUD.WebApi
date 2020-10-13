using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.CRUD.WebApi.Model;
using Dapper.CRUD.WebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Dapper.CRUD.WebApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        public ProductsController()
        {

        }

        [Route("GetProductList")]
        [HttpGet]
        public ActionResult<List<ProductModel>> GetProducts()
        {
            //Tüm ürünleri getirme
            GetServices getServices = new GetServices();
            return getServices.getProducts();
        }

        [Route("GetStockNrByName")]
        [HttpPost]
        public ActionResult<int> GetStockNumberByProductName([FromBody] ProductModel productModel)
        {
            PostServices postServices = new PostServices();
            return postServices.getStockNumberOfProduct(productModel.Product_Name);
        }


        //Create
        [Route("SaveProduct")]
        [HttpPost]
        public ActionResult<bool> SaveProduct([FromBody] ProductModel productModel)
        {
            PostServices postServices = new PostServices();
            return postServices.saveProductDB(productModel);

        }

        //Update
        [HttpPost("[action]/{id}")]
        public ActionResult<bool> UpdateProduct(int id,[FromBody] ProductModel productModel)
        {
            PostServices postServices = new PostServices();
            return postServices.updateProductDB(id,productModel);
        }

        //Delete
        [HttpPost("[action]/{id}")]
        public ActionResult<bool> DeleteProduct(int id)
        {
            PostServices postServices = new PostServices();
            return postServices.deleteProductDB(id);
        }
    }
}
