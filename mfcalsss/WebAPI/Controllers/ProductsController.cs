using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using busiziii.absc;
using busiziii.concan;
using DataAccsess.cerezzz.EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using varlıksss.cerezz;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("Get")]
    
        public List<Product>  Get() //IActionResult
        {
            IProductService productService = new ProductManager(new EfProductDal());
            var result = productService.GetAll();
            return result.Data;


        }
    }
}

//return new List<Product>
//{
//    {
//    new Product {ProductID=1,ProductName="Elammmsada"}
//   , new Product {ProductID=2,ProductName ="züürt" },







//};