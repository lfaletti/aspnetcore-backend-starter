using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities.Products;
using Core.Interfaces.Products;

namespace Core.Services
{
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
