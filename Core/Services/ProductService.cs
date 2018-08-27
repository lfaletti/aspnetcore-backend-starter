using Core.Entities.Products;
using Core.Interfaces.Products;
using Core.Interfaces.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Services
{
    /// <summary>
    /// Domain Service class for Products.
    /// </summary>
    public class ProductService : IProductService
    {
        private IProductRepository<int> _productRepository;

        public ProductService(IProductRepository<int> productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var result = await _productRepository.ListAllAsync();

            return result;
        }

        public async Task GetByIdAsync(int id)
        {
            await _productRepository.GetByIdAsync(id);
        }
    }
}
