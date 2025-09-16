using Prn222Project.Models;
namespace Prn222Project.Services
{
    public interface IProductServices
    {
        List<Product> GetAllProducts();
        List<Product> GetActiveProducts(int? page, int? pageSize, int? categories, string? search,
            decimal? minPrice, decimal? maxPrice, string? orderBy, string? orderStatus);
        int GetTotalPage(int? page, int pageSize, int? categories, string? search,
           decimal? minPrice, decimal? maxPrice, string? orderBy, string? orderStatus);
        List<Category> GetAllCategories();
        Product GetProductById(int id);
        ProductVariant GetProductVariantById(int id);
    }
}
