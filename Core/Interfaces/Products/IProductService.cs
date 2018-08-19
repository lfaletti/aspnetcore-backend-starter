using Core.Entities.Products;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.Products
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task GetByIdAsync(int id);
    }
}
