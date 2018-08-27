using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.ViewModels;

namespace WebApi.Interfaces
{
    public interface IProductsViewService
    {
        Task<List<ProductViewModel>> GetProducts();
    }
}
