using Microsoft.AspNetCore.Mvc;
using ProductsCatalogue.Services.Interfaces;

namespace ProductsCatalogue.Controllers
{
    [Route("api/v1/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
             _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken ct)
        {
            
            var products = await _productService.GetAllAsync(ct);

            if (products.Count > 0)
            {
                return Ok(products);
            }

            return NotFound();
        }
    }
}
