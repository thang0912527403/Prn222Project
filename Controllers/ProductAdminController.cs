using Microsoft.AspNetCore.Mvc;
using Prn222Project.Models;
using Prn222Project.Services;

namespace Prn222Project.Controllers
{
    public class ProductAdminController : Controller
    {
        private readonly IProductServices _productServices;

        public ProductAdminController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        [HttpGet]
        public IActionResult Index(int page = 1, int pageSize = 10)
        {
            var allProducts = _productServices.GetAllProducts();

            var totalProducts = allProducts.Count();
            var totalPages = (int)Math.Ceiling(totalProducts / (double)pageSize);

            var products = allProducts
                .OrderByDescending(p => p.ModifiedDate)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.Page = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.PageSize = pageSize;

            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = _productServices.GetAllCategories();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product, IFormFile? imageFile, List<int>? categoryIds)
        {
            ModelState.Remove(nameof(Product.ProductCategories));

            if (!ModelState.IsValid)
            {
                ViewBag.Categories = _productServices.GetAllCategories();
                return View(product);
            }

            if (categoryIds != null && categoryIds.Count > 0)
            {
                product.ProductCategories ??= new List<ProductCategory>();

                foreach (var catId in categoryIds.Distinct())
                    product.ProductCategories.Add(new ProductCategory { CategoryId = catId });
            }

            _productServices.AddProduct(product, imageFile);

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = _productServices.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Product product, IFormFile? imageFile)
        {
            if (ModelState.IsValid)
            {
                _productServices.UpdateProduct(product, imageFile);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var product = _productServices.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }

            _productServices.SoftDeleteProduct(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
