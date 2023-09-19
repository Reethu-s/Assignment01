using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private ProductDbContext _dbContext;

        public ProductApiController(ProductDbContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_dbContext.Products.ToList());
        }

        [HttpPost]
        public IActionResult Create([FromBody] Product obj)
        {
            _dbContext.Products.Add(obj);
            _dbContext.SaveChanges();
            return Ok(new { result = "Product Details added to db" });
        }

        [HttpPut]
        public IActionResult Edit([FromBody] Product obj)
        {
            _dbContext.Entry(obj).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return Ok(new { result = "Product Details updated to db" });
        }


        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            Product obj = _dbContext.Products.Find(id);

            if (obj == null)
            {
                return NotFound(new { result = "Requested product details are not available." });
            }
            else
            {
                return Ok(obj);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            Product obj = _dbContext.Products.Find(id);
            _dbContext.Products.Remove(obj);
            _dbContext.SaveChanges();
            return Ok(new { result = "Product Details deleted from db" });
        }
    }


}

