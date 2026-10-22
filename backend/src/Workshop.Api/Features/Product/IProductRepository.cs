using Workshop.Domain.Features.Product;

namespace Workshop.Api.Features.Product
{
    public interface IProductRepository
    {
        Task<ProductEntity?> GetByIdAsync(int id);
        Task<IReadOnlyList<ProductEntity>> GetAllAsync();
        Task<ProductEntity> CreateAsync(ProductEntity product);
    }
}
