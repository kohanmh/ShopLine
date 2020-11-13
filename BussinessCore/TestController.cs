

using Microsoft.AspNetCore.Mvc;
using ShopLine.DTO;
using System.Collections.Generic;
using System.Linq;

namespace ShopLine.Web
{
    //[Route("api/Test")]
   // [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private static List<Product> Products = new List<Product>();



        //[HttpGet]
        //public IActionResult Get()
        //{
        //    //Products.Add(new Product { Code = 1, ProductName = "Pasta", Success = true });

        //    return Ok(Products);
        //}

        [HttpGet]
        //[Route("[id]")]
        public IActionResult GetByID(int id)
        {
            //ListProductQueryResult result = new ListProductQueryResult();
            //result.Entities = new List<Product>();
            //result.Entities.Add(new Product { Code = 1, ProductName = "Pasta", Success = true });

            return Ok(Products.FirstOrDefault(x=> x.Code == id));
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            //ListProductQueryResult result = new ListProductQueryResult();
            //result.Entities = new List<Product>();
            //result.Entities.Add(new Product { Code = 1, ProductName = "Pasta", Success = true });
            
            Products.Add(product);
            return Created($"/Product/{product.Code}",product);
        }
    }
}
