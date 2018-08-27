using Core.Entities.Products;
using Core.Interfaces.Repositories;

namespace Core.Interfaces.Repositories
{
    public interface IProductRepository<TKey> : IAsyncRepository<Product>
    {
        // Add specific methods for this repository here...
    }
}
