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

        [HttpGet("getAll")]
    
        public IActionResult  GetAll() //IActionResult
        {
            // IProductService productService = new ProductManager(new EfProductDal());
            var result = _productService.GetAll();

            if (result.Success)
            {


                return Ok(result.Data );


            }

            return BadRequest(result);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById (int id)
        {
            var result = _productService.GetById(id);
                if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }



        [HttpPost("add")]
         public IActionResult Add(Product product)
        {
            var result = _productService.Add(product );
            if (result.Success )
            {
                return Ok(result);
            }
            return BadRequest(result);




        }


    }
}

//return new List<Product>
//{
//    {
//    new Product {ProductID=1,ProductName="Elammmsada"}
//   , new Product {ProductID=2,ProductName ="züürt" },







//};