using Microsoft.AspNetCore.Mvc;
using Model.Operation;
using Model.Services;

namespace ProductServiceHost.Controllers
{
    [Route("api/v1/product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            return Ok(_productService.CreateProduct(product));
        }

        [HttpGet]
        public IActionResult GetProduct([FromQuery] long id)
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteProduct()
        {
            return Ok();
        }

        [HttpPatch]
        public IActionResult UpdateProduct()
        {
            return Ok();
        }
    }
}
