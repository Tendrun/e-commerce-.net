using Workshop.Domain.Features.Product;
using Microsoft.EntityFrameworkCore;
using Workshop.Api.Data;

namespace Workshop.Api.Features.Product
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ProductRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task<ProductEntity?> GetByIdAsync(int id)
        {
            return await applicationDbContext.Products
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IReadOnlyList<ProductEntity>> GetAllAsync()
        {
            return await applicationDbContext.Products
            .AsNoTracking()
            .ToListAsync(); 
        }

        public async Task<ProductEntity> CreateAsync(ProductEntity product)
        { 
            await applicationDbContext.Products.AddAsync(product);
            await applicationDbContext.SaveChangesAsync();
            return product;
        }
    }
}
