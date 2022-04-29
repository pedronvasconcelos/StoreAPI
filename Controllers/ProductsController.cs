using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreAPI.Context;
using StoreAPI.Models;

namespace StoreAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;

        }

        [HttpGet]
        public ActionResult <IEnumerable<Product>> Get()
        {
            var products = _context.Products.AsNoTracking().ToList();
            if(products is null) 
            {
                return NotFound("Products not found");
            }
            return products;
        }

        [HttpGet("{id}", Name = "GetProduct")]
        public ActionResult <Product> Get(int id)
        {
            var product = _context.Products.AsNoTracking().FirstOrDefault(p => p.ProductId == id);
            if (product is null)
            {
                return NotFound("Product not found");   
            }
            return product;
        }

        [HttpPost]
        public ActionResult<Product> Post(Product product)
        {
            if (product is null)
            {
                return BadRequest("Product is null");
            }
            
            _context.Products.Add(product);
            _context.SaveChanges();
            return new CreatedAtRouteResult("GetProduct",
                new { id = product.ProductId }, product);
        }

        [HttpPut("{id:int}")]
        public ActionResult<Product> Put(int id, Product product)
        {
            if (id != product.ProductId)
            {
                return BadRequest("Product ids don't match");
            }

            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(product);
        }

        [HttpDelete("{id:int}")]
        public ActionResult<Product> Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == id);
            if (product is null)
            {
                return NotFound("Product not found");
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
            return Ok(product);
        }
    }
}
