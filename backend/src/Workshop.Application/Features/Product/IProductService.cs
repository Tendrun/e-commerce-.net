namespace Workshop.Application.Features.Product
{
    public interface IProductService
    {
        public Task<IReadOnlyList<ProductResponseDTO>> products();
        public Task<ProductResponseDTO?> products(int id);
        public Task<ProductResponseDTO?> CreateProducts(CreateProductRequestDTO createProductDTO);
    }
}
