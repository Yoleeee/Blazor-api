using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp7.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _context;
        public ProductController(DataContext dataContext)
        {
            _context = dataContext;
        }



        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }
        [HttpGet("GetACouple")]
        public async Task<ActionResult<List<Product>>> GetProductNumber([FromQuery]int count)
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products.Take(count));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetSingleProduct(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(product => product.Id == id);
            return Ok(product);
        }
        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct([FromBody] Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return Created("",product);
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(product => product.Id == id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return Ok(product);
        }
        [HttpPut("update/{id}")]
        public async Task<ActionResult<Product>> UpdateProduct(int id,Product request)
        {
            var product = await _context.Products.FirstOrDefaultAsync(product => product.Id == id);
            product.Title = request.Title;
            product.Description = request.Description;
            product.ImageUrl = request.ImageUrl;
            product.Price = request.Price;
            await _context.SaveChangesAsync();
            return Ok(product);
        }
        [HttpGet("GetByTitle/{title}")]
        public Product GetAProduct(string title)
        {
            var product = _context.Products.FirstOrDefault(product => product.Title == title);
            return product;
        }
    }
}
