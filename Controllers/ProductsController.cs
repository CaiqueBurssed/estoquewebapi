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
        public ActionResult<IEnumerable<ProductReadDto>> getAllProducts()
        {
            var productItems = _repository.getAllProducts();

            return Ok(_mapper.Map<IEnumerable<ProductReadDto>>(productItems));
        }

        //GET api/products/{id}
        [HttpGet("{id}", Name = "getProductById")]
        public ActionResult<ProductReadDto> getProductById(int id)
        {
            var productItem = _repository.getProductById(id);
            if(productItem != null)
            {
                return Ok(_mapper.Map<ProductReadDto>(productItem));
            }
            return NotFound();

        }

        //POST api/products
        [HttpPost]
        public ActionResult<ProductReadDto> createProduct(ProductCreateDto productCreateDto)
        {
            var productModel = _mapper.Map<Product>(productCreateDto);
            _repository.createProduct(productModel);
            _repository.SaveChanges();

            var productReadDto = _mapper.Map<ProductReadDto>(productModel);

            return CreatedAtRoute(nameof(getProductById), new { Id = productReadDto.Id }, productReadDto);

        }

        //PUT api/products/{id}
        [HttpPut("{id}")]
        public ActionResult updateProduct(int id, ProductUpdateDto productUpdateDto)
        {
            var productModelFromRepo = _repository.getProductById(id);

            if(productModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(productUpdateDto, productModelFromRepo);

            _repository.updateProduct(productModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        //DELETE api/products/{id}
        [HttpDelete("{id}")]
        public ActionResult deleteProduct(int id)
        {
            var productModelFromRepo = _repository.getProductById(id);
            if(productModelFromRepo  == null)
            {
                return NotFound();
            }
            _repository.deleteProduct(productModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

    }
}
