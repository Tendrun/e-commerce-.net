using Microsoft.AspNetCore.Mvc;

namespace Workshop.Api.Features.Product
{
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

        [HttpGet("{id}")]
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
            await productService.CreateProducts(createProductDTO);
        }
    }
}
