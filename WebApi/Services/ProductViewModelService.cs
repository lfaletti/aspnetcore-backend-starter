using Core.Interfaces.Products;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Interfaces;
using WebApi.ViewModels;

namespace WebApi.Services
{
    /// <summary>
    /// View model class to render view data returned by domain services.
    /// </summary>
    public class ProductViewModelService : IProductsViewService
    {
        private IProductService _productService; 

        public ProductViewModelService(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<List<ProductViewModel>> GetProducts()
        {
            var products = await _productService.GetAllAsync();

            var productsViewModel = new List<ProductViewModel>();

            products.ToList().ForEach(e => productsViewModel.Add(new ProductViewModel()
            {
                Name = e.Name
            }));

            return productsViewModel;
        }
    }
}
