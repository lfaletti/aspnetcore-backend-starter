using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.ViewModels;

namespace WebApi.Interfaces
{
    public interface IProductViewModelService
    {
        Task<List<ProductViewModel>> GetProducts();
    }
}
