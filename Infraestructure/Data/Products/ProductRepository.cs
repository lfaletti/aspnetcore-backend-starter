using Core.Entities.Products;
using Core.Interfaces.Repositories;

namespace Infraestructure.Data.Products
{
    public class ProductRepository : Repository<Product>, IProductRepository<int> 
    {
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
