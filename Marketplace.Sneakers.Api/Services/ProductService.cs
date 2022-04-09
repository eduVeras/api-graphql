using Marketplace.Sneakers.Api.Entities;
using Marketplace.Sneakers.Api.Repositories;

namespace Marketplace.Sneakers.Api.Services
{
    public interface IProductService
    {
        Task<Product> GetByIdAsync(Guid guid);
        Task InsertAsync(Product product);
        Task UpdateAsync(Product product);
        Task RemoveAsync(Guid guid);
        Task<IEnumerable<Product>> GetAllAsync();
    }

    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<ProductService> _logger;

        public ProductService(IProductRepository productRepository, ILogger<ProductService> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
