using Microsoft.AspNetCore.Mvc;
using WebApplication1.Business;
using WebApplication1.Entities;
using WebApplication1.Interfaces;

namespace WebApplication1.Controllers
{
    //GET https://localhost:5001/api/product/Phone/1/iPhone%2012/1000
  
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{type}/{id}/{name}/{price}")]
        public IActionResult CreateProduct(ProductType type, int id, string name, decimal price)
        {
            try
            {
                IProduct product = _productService.CreateProduct(type, id, name, price);
                return Ok(product);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

}
