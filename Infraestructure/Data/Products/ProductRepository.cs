using Core.Entities.Products;
using Core.Interfaces;
using Core.Interfaces.Products;

namespace Infraestructure.Data.Products
{
    public class ProductRepository : Repository<Product>, IProductRepository<int> 
    {
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
