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
        private readonly IProductRepo _repository;

        public ProductsController(IProductRepo repository)
        {
            _repository = repository;
        }

        //GET api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> getAllProducts()
        {
            var productItems = _repository.getAllProducts();

            return Ok(productItems);
        }

        //GET api/products/{id}
        [HttpGet("{id}")]
        public ActionResult<Product> getProductById(int id)
        {
            var productItem = _repository.getProductById(id);

            return Ok(productItem);
        }


    }
}
