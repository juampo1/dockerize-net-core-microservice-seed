using Microsoft.AspNetCore.Mvc;
using Model.Services;

namespace ProductServiceHost.Controllers
{
    class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public IActionResult CreateProduct()
        {
            return Ok();
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
