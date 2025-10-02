using Prn222Project.Models;
namespace Prn222Project.DataAccess
{
    public interface IProductDA
    {
        List<Product> GetAllProducts();
        List<Product> GetActiveProducts(int? page, int? pageSize, int? categories, string? search,
            decimal? minPrice, decimal? maxPrice, string? orderBy, string? orderStatus);
        int getTotalPage(int? page, int pageSize, int? categories, string? search,
    decimal? minPrice, decimal? maxPrice, string? orderBy, string? orderStatus);
        List<Category> GetAllCategories();  
        Product GetProductById(int id);
        ProductVariant GetProductVariantById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product); 
        void DeleteProduct(int id);
    }
}
