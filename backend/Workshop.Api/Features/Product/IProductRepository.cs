using Microsoft.AspNetCore.Mvc;

namespace Workshop.Api.Features.Product
{
    public interface IProductRepository
    {
        Task<ProductEntity?> GetByIdAsync(int id);
        Task<IReadOnlyList<ProductEntity>> GetAllAsync();
        Task<ProductEntity> CreateAsync(ProductEntity product);
    }
}
