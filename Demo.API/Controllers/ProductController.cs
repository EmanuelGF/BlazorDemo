using Demo.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("getProducts")]
        public IActionResult getProducts()
        {
            List<Product> _productList = new List<Product>()
            {
                new Product{Id=1, Name="Product1", Brand="Brand1", Price=1, Quantity=1 },
                new Product{Id=2, Name="Product2", Brand="Brand2", Price=2, Quantity=2 },
                new Product{Id=3, Name="Product3", Brand="Brand3", Price=3, Quantity=3 },
                new Product{Id=4, Name="Product4", Brand="Brand4", Price=4, Quantity=4 }
            };

            return Ok(_productList);
        }
    }
}
