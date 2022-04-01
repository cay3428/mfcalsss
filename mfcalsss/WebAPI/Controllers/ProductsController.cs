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
        [HttpGet("Get")]
        public IActionResult Get()
        {
            IProductService productService = new ProductManager(new EfProductDal());
            var result = productService.GetAll();
           return Ok(result);


        }
    }
}

//return new List<Product>
//{
//    {
//    new Product {ProductID=1,ProductName="Elammmsada"}
//   , new Product {ProductID=2,ProductName ="züürt" },







//};