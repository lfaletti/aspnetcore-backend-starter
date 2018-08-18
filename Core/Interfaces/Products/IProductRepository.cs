using Core.Entities.Products;

namespace Core.Interfaces.Products
{
    public interface IProductRepository<TKey> : IAsyncRepository<Product>
    {
        // Add specific methods for this repository here...
    }
}
