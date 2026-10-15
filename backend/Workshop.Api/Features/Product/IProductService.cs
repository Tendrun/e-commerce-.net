using Microsoft.AspNetCore.Mvc;

namespace Workshop.Api.Features.Product
{
    public interface IProductService
    {
        public Task<IReadOnlyList<ProductResponseDTO>> products();
        public Task<ProductResponseDTO?> products(int id);
        public Task<IActionResult> CreateProducts(CreateProductRequestDTO createProductDTO);
    }
}
