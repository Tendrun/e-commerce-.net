using Microsoft.AspNetCore.Mvc;

using Workshop.Application.Features.Product;

namespace Workshop.Api.Features.Product
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : Controller
    {
        IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> products()
        {
            var products = await productService.products();
            return Ok(products);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> products(int id)
        {
            var product = await productService.products(id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> products(CreateProductRequestDTO createProductDTO)
        {
            ProductResponseDTO? productResponse = await productService.CreateProducts(createProductDTO);

            if (productResponse == null)
                return BadRequest();

            return Ok(productResponse);
        }
    }
}
