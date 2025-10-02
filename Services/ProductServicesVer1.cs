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

        public void AddProduct(Product product, IFormFile? imageFile)
        {
            if (imageFile != null && imageFile.Length > 0)
            {
                string folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products");
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                string fileName = Guid.NewGuid() + Path.GetExtension(imageFile.FileName);
                string filePath = Path.Combine(folder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    imageFile.CopyTo(stream);
                }

                product.ImageUrl = "/images/products/" + fileName;
            }

            product.IsActive = true;
            product.IsDeleted = false;
            product.ModifiedDate = DateTime.Now;

            _productDA.AddProduct(product);
        }

        public void UpdateProduct(Product product, IFormFile? imageFile = null)
        {
            if (imageFile != null && imageFile.Length > 0)
            {
                string folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/products");
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                string fileName = Guid.NewGuid() + Path.GetExtension(imageFile.FileName);
                string filePath = Path.Combine(folder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    imageFile.CopyTo(stream);
                }

                product.ImageUrl = "/images/products/" + fileName;
            }

            product.ModifiedDate = DateTime.Now;
            _productDA.UpdateProduct(product);
        }

        public void SoftDeleteProduct(int id)
        {
            var product = _productDA.GetProductById(id);
            if (product != null)
            {
                product.IsActive = false;
                product.ModifiedDate = DateTime.Now;
                _productDA.UpdateProduct(product);
            }
        }
    }
}
