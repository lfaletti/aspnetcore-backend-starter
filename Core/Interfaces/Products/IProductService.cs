using System.Threading.Tasks;

namespace Core.Interfaces.Products
{
    public interface IProductService
    {
        Task GetAllAsync();
        Task GetByIdAsync(string id);
    }
}
