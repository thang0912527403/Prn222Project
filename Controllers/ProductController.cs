using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Prn222Project.Helpers;
using Prn222Project.Models;
using Prn222Project.Services;
using Prn222Project.ViewModels;
using Prn222Project.Data;
namespace Prn222Project.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        public class AddToCartRequest
        {
            public int ProductId { get; set; }
            public int VariantId { get; set; }
            public int Quantity { get; set; }
        }
        private readonly IProductServices _productServices;
        private readonly ApplicationDbContext _context;
        public ProductController(IProductServices productServices,ApplicationDbContext context)
        {
            _productServices = productServices;
            _context = context;
        }
        [Route("products")]
        [HttpGet]
        public IActionResult Index(int? page, int? pageSize, int? categories, string? search,
    decimal? minPrice, decimal? maxPrice, string? orderBy, string? orderStatus)
        {
            if (!pageSize.HasValue) pageSize = 12;
            else if (pageSize > 20) return Redirect("/products");
            else if (pageSize < 1) return Redirect("/products");
            if (minPrice > maxPrice) { decimal? t = minPrice; minPrice = maxPrice; maxPrice = t; }
            var totalPage = _productServices.GetTotalPage(page, pageSize.Value, categories, search, minPrice, maxPrice, orderBy, orderStatus);
            if (!page.HasValue ) page = 1;
            else if (page > totalPage) page = totalPage;
            else if(page<1) return Redirect("/products");
            var products = _productServices.GetActiveProducts(page, pageSize, categories, search,
         minPrice, maxPrice, orderBy, orderStatus);
            List<Category> categoriesList = _productServices.GetAllCategories();
            ViewBag.OrderBy = orderBy;
            ViewBag.OrderStatus = orderStatus;
            ViewBag.Page = page;
            ViewBag.PageSize = pageSize;
            ViewBag.TotalPage = totalPage;
            ViewBag.Categories = categoriesList;
            ViewBag.MinPrice = minPrice;
            ViewBag.MaxPrice = maxPrice;
            ViewBag.cate = categories;
            return View(products);
        }
        public IActionResult Details(int id)
        {
            var product = _productServices.GetProductById(id);
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddToCart([FromBody] AddToCartRequest request)
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            var existingItem = cart.FirstOrDefault(x => x.productVariantId == request.VariantId);

            if (existingItem != null)
            {
                existingItem.quantity += request.Quantity;
            }
            else
            {
                // Get variant and product info once
                var variant = _productServices.GetProductVariantById(request.VariantId);
                var product = _productServices.GetProductById(request.ProductId);

                cart.Add(new CartItem
                {
                    color = variant.Color,
                    decoration = variant.Decoration,
                    productVariantId = request.VariantId,
                    productName = product.Name,
                    price = variant.Price,
                    quantity = request.Quantity
                });
            }

            HttpContext.Session.SetObjectAsJson("Cart", cart);
            return Json(new { success = true, message = "Đã thêm vào giỏ hàng!" });
        }
        public IActionResult Cart()
        {
            // Handle null case - return empty list instead of null
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            return View(cart);
        }

        // Optional: Add methods to manage cart
        public IActionResult RemoveFromCart(int variantId)
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            var itemToRemove = cart.FirstOrDefault(x => x.productVariantId == variantId);

            if (itemToRemove != null)
            {
                cart.Remove(itemToRemove);
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }

            return RedirectToAction("Cart");
        }

        public IActionResult UpdateCartQuantity(int variantId, int quantity)
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            var item = cart.FirstOrDefault(x => x.productVariantId == variantId);

            if (item != null)
            {
                if (quantity <= 0)
                {
                    cart.Remove(item);
                }
                else
                {
                    item.quantity = quantity;
                }
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }

            return RedirectToAction("Cart");
        }

        public IActionResult ClearCart()
        {
            HttpContext.Session.Remove("Cart");
            return RedirectToAction("Cart");
        }
        [HttpGet]
        public IActionResult Checkout()
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            if (cart.Count == 0)
            {
                ViewBag.Message = "Giỏ hàng trống.";
                return View();
            }
            decimal totalPrice = 0;
            foreach (var item in cart)
            {
                totalPrice += item.price * item.quantity;
            }
            ViewBag.TotalPrice = totalPrice;
            return View(cart);
        }
        [Authorize]
        [HttpPost]
        public IActionResult CheckoutCart()
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            if (cart.Count == 0)
                if (cart.Count == 0)
            {
                ViewBag.Message = "Giỏ hàng trống.";
                return View();
            }
            string userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var order = new Orders
            {
                UserId = userId,
                order_date = DateTime.Now
            };

            _context.Orders.Add(order);
            _context.SaveChanges(); 
            foreach (var item in cart)
            {
                var detail = new OrderDetail
                {
                    order_id = order.order_id,
                    productVariant_id = item.productVariantId,
                    unit_price = item.price,
                    quantity = item.quantity
                };
                _context.OrderDetails.Add(detail);
            }

            _context.SaveChanges();
            HttpContext.Session.Remove("Cart");
            ViewBag.Message = "Đặt hàng thành công!";
            return Redirect("products");
        }
    }
}
