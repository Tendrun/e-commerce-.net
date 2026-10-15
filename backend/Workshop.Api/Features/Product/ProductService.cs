using Microsoft.AspNetCore.Mvc;

namespace Workshop.Api.Features.Product
{
    public class ProductService : IProductService
    {
        IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<IReadOnlyList<ProductResponseDTO>> products()
        {
            IReadOnlyList<ProductEntity> productEntities =
             await productRepository.GetAllAsync(); 

            return productEntities.Select(p => new ProductResponseDTO
            {
                id = p.Id,
                name = p.Name,
                price = p.Price,
                stock = p.Stock,
                CreatedAt = p.CreatedAt
            })
            .ToList();
        }

        public async Task<ProductResponseDTO?> products(int id)
        {
            var productEntity = await productRepository.GetByIdAsync(id);

            if (productEntity == null)
                return null;

            return new ProductResponseDTO
            {
                id = productEntity.Id,
                name = productEntity.Name,
                price = productEntity.Price,
                stock = productEntity.Stock,
                CreatedAt = productEntity.CreatedAt
            };
        }

        public async Task<ProductResponseDTO> CreateProducts(CreateProductRequestDTO createProductDTO)
        {
            await productRepository.CreateAsync(new ProductEntity
            {
                Name = createProductDTO.Name,
                Price = createProductDTO.Price,
                Stock = createProductDTO.Stock
            });
        }
    }
}
