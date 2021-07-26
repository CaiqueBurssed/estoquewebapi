using EstoqueWebAPI.Model;
using EstoqueWebAPI.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EstoqueWebAPI.Dtos;

namespace EstoqueWebAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IEstoqueRepo _repository;
        private readonly IMapper _mapper;

        public ProductsController(IEstoqueRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
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
        public ActionResult<ProductReadDto> getProductById(int id)
        {
            var productItem = _repository.getProductById(id);
            if(productItem != null)
            {
                return Ok(_mapper.Map<ProductReadDto>(productItem));
            }
            return NotFound();

        }


    }
}
