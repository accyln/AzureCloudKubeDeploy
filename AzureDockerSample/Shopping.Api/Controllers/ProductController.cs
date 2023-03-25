using Microsoft.AspNetCore.Mvc;
using Shopping.Api.Data;
using Shopping.Api.Models;

namespace Shopping.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController:ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            List<Product> products = ProductContext.products;

            return Ok(products);
        }
    }
}
