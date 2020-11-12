using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Filter;
using AutoMapper;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService,IMapper mapper)
        {
            _mapper = mapper;
            _productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<Product>>(products));//
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(_mapper.Map<ProductDto>(await _productService.GetByIdAsync(id)));
        }
        [ValidationFilter]
        [HttpPost]
        public async Task<IActionResult> Save([FromBody] ProductDto productDto)
        {
            await _productService.AddAsync(_mapper.Map<Product>(productDto));
            return Created(String.Empty,productDto);
        }
        [HttpPut]
        public Task<IActionResult> Update([FromBody] ProductDto productDto)
        {
            _productService.Update(_mapper.Map<Product>(productDto));
            return Update(productDto);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productService.Remove(_productService.GetByIdAsync(id).Result);
            return NoContent();
        }
        [HttpGet("{id}/category")]
        public async Task<IActionResult> GetWithCategoryById(int id)
        {
            var product = await _productService.GetWithCategoryByIdAsync(id);
            return Ok(_mapper.Map<ProductWithCategoryDto>(product));
        }



    }
}
