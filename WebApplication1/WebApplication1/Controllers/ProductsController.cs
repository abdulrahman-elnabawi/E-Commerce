using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
        [ApiController]
        [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "This is a list of products";
        }
        [HttpGet]
        [Route("{id}")]
        public string GetProduct(int id)
        {
            return $"This is product {id}";
        }


    }
}