using Api_Denemesi.Data;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api_Denemesi.Controllers
{
    [EnableCors]
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ProductContext _context;

        public CategoriesController(ProductContext context)
        {
            _context = context; 
        }

        [HttpGet("api/[controller]")]
        public IActionResult GetWithProduct(int id)
        {
            var data = _context.Categories.Include(x => x.Products).SingleOrDefaultAsync(x => x.Id == id);

            if (data ==null)
            {
                return NotFound(id);
            }
            return Ok(data);
        }



    }
}
