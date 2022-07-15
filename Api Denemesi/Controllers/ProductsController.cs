using Api_Denemesi.Data;
using Api_Denemesi.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Api_Denemesi.Controllers
{

    [EnableCors]
    [ApiController]
    [Route("api/{Controller}")]
    public class ProductsController : ControllerBase
    {

        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _productRepository.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _productRepository.GetByIdAsync(id);

            if (data==null)
            {
                return NotFound(id);
            }
        
            return Ok(data);
        }


        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            var addedProduct = await _productRepository.CreateAsync(product);
            return Created(string.Empty, addedProduct);
        }


        [HttpPut]
        public async Task<IActionResult> Update(Product product)
        {
           var updated= await _productRepository.GetByIdAsync(product.Id);
            if (updated==null)
            {
                return NotFound(product.Id);
            }
            await _productRepository.UpdateAsync(product);  
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var deleted = await _productRepository.GetByIdAsync(id);
            if (deleted == null)
            {
                return NotFound(id);
            }
            await _productRepository.RemoveAsync(id);
            return NoContent();
        }

        //api/product/upload
        [HttpPost("Upload")]
        public async Task<IActionResult> Upload([FromForm]IFormFile formFile)
        {
            var newName = Guid.NewGuid() + "." + Path.GetExtension(formFile.FileName);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", newName);
            var stream = new FileStream("", FileMode.Create);
            await formFile.CopyToAsync(stream);
            return Created(string.Empty, formFile);
        }

        [HttpGet("[action]")]
        public IActionResult Test(IDummyRepository dummyRepository)
        {
            
            return Ok(dummyRepository.GetName());
        }
    
    }
}
