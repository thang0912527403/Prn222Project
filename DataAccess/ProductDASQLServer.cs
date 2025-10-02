using Microsoft.EntityFrameworkCore;
using Prn222Project.Models;
using System.Linq;
using Prn222Project.Data;
namespace Prn222Project.DataAccess
{
    public class ProductDASQLServer : IProductDA
    {
        private readonly ApplicationDbContext _context;
        public ProductDASQLServer(ApplicationDbContext context)
        {
            _context = context;
        }
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
        List<Product> IProductDA.GetAllProducts()
        {
            return _context.Products
                .Where(p => p.IsActive && !p.IsDeleted)
                .Include(p => p.ProductVariants)
                .Include(p => p.ProductCategories)
                .ToList();
        }
        public List<Product> GetActiveProducts(int? page, int? pageSize, int? categories, string? search,
    decimal? minPrice, decimal? maxPrice, string? orderBy, string? orderStatus)
        {
            var query = _context.Products
                .Where(p => p.IsActive && !p.IsDeleted)
                .Include(p => p.ProductVariants)
                .Include(p => p.ProductCategories)
                .AsQueryable();
            if (categories.HasValue)
            {
                query = query.Where(p => p.ProductCategories.Any(pc => pc.CategoryId == categories.Value));
            }
            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(p =>
                    p.Name.Contains(search) ||
                    (p.Description != null && p.Description.Contains(search))
                );
            }
            if (minPrice.HasValue)
            {
                query = query.Where(p => p.ProductVariants.Any(v => v.Price >= minPrice.Value));
            }
            if (maxPrice.HasValue)
            {
                query = query.Where(p => p.ProductVariants.Any(v => v.Price <= maxPrice.Value));
            }
            bool isAsc = string.Equals(orderStatus, "Ascending", StringComparison.OrdinalIgnoreCase);
            switch (orderBy?.ToLower())
            {
                case "price":
                    //query = isAsc
                    //    ? query.OrderBy(p => p.ProductVariants.Min(v => v.Price))
                    //    : query.OrderByDescending(p => p.ProductVariants.Max(v => v.Price));
                    query = isAsc
                       ? query.OrderBy(p => p.Price)
                       : query.OrderByDescending(p => p.ProductVariants.Max(v => v.Price));
                    break;
                case "name":
                    query = isAsc
                        ? query.OrderBy(p => p.Name)
                        : query.OrderByDescending(p => p.Name);
                    break;
                default:
                    query = query.OrderBy(p => p.Id);
                    break;
            }
            if (page.HasValue && pageSize.HasValue)
            {
                int skip = Math.Max(0, (page.Value - 1) * pageSize.Value);
                query = query.Skip(skip).Take(pageSize.Value);
            }
            return query.ToList();
        }

        int IProductDA.getTotalPage(int? page, int pageSize, int? categories, string? search,
    decimal? minPrice, decimal? maxPrice, string? orderBy, string? orderStatus)
        {
            var query = _context.Products
                .Where(p => p.IsActive && !p.IsDeleted)
                .Include(p => p.ProductVariants)
                .Include(p => p.ProductCategories)
                .AsQueryable();
            if (categories.HasValue)
            {
                query = query.Where(p => p.ProductCategories.Any(pc => pc.CategoryId == categories.Value));
            }
            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(p =>
                    p.Name.Contains(search) ||
                    (p.Description != null && p.Description.Contains(search))
                );
            }
            if (minPrice.HasValue)
            {
                query = query.Where(p => p.ProductVariants.Any(v => v.Price >= minPrice.Value));
            }
            if (maxPrice.HasValue)
            {
                query = query.Where(p => p.ProductVariants.Any(v => v.Price <= maxPrice.Value));
            }
            var totalProducts = query.Count();
            return (int)Math.Ceiling((decimal)totalProducts / pageSize);
        }
        public List<Category> GetAllCategories()
        {
            return _context.Categories
                .Where(c => !c.IsDeleted)
                .ToList();
        }
        Product IProductDA.GetProductById(int id)
        {
            return _context.Products
                .Include(p => p.ProductVariants)
                .Include(p => p.ProductCategories)
                .FirstOrDefault(p => p.Id == id && p.IsActive && !p.IsDeleted);
        }
        ProductVariant IProductDA.GetProductVariantById(int id)
        {
            return _context.ProductVariants
                .Include(v => v.Product)
                .FirstOrDefault(v => v.Id == id);
        }
    }
}