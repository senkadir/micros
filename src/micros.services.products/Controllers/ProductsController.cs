using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace micros.services.products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/Products
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Product 1", "Product 2" };
        }

        // GET: api/Products/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return $"Product {id}";
        }
    }
}
