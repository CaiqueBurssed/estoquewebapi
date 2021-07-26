using EstoqueWebAPI.Model;
using EstoqueWebAPI.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstoqueWebAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //GET api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> getAllProducts()
        {

        }

        //GET api/products/{id}
        [HttpGet("{id}")]
        public ActionResult<Product> getProductById(int id)
        {

        }

    }
}
