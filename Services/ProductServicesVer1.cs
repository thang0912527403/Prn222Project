using Prn222Project.DataAccess;
using Prn222Project.Models;
namespace Prn222Project.Services
{
    public class ProductServicesVer1 : IProductServices
    {
        private readonly IProductDA _productDA;
        public ProductServicesVer1(IProductDA productDA)
        {
            _productDA = productDA;
        }
        public List<Product> GetAllProducts()
        {
            return _productDA.GetAllProducts();
        }
        public List<Product> GetActiveProducts(int? page, int? pageSize, int? categories, string? search,
           decimal? minPrice, decimal? maxPrice, string? orderBy, string? orderStatus)
        {
            return _productDA.GetActiveProducts(page, pageSize, categories, search,
             minPrice, maxPrice, orderBy, orderStatus);
        }
        int IProductServices.GetTotalPage(int? page, int pageSize, int? categories, string? search,
           decimal? minPrice, decimal? maxPrice, string? orderBy, string? orderStatus)
        {
            return _productDA.getTotalPage(page, pageSize, categories, search, minPrice, maxPrice, orderBy, orderStatus);
        }
        List<Category> IProductServices.GetAllCategories()
        {
            return _productDA.GetAllCategories();
        }
        Product IProductServices.GetProductById(int id)
        {
            return _productDA.GetProductById(id);
        }
        ProductVariant IProductServices.GetProductVariantById(int id)
        {
            return _productDA.GetProductVariantById(id);
        }
    }
}
