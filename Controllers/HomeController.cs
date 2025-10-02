using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prn222Project.Models;
using Prn222Project.Services;
using Prn222Project.ViewModels;

namespace Prn222Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductServices _productServices;

        public HomeController(ILogger<HomeController> logger, IProductServices productServices)
        {
            _logger = logger;
            _productServices = productServices;
        }

        public IActionResult Index()
        {
            if (TempData["NotificationStatus"] != null)
            {
                ViewBag.Notification = new Notification
                {
                    Component = TempData["NotificationComponent"]?.ToString(),
                    Status = TempData["NotificationStatus"]?.ToString(),
                    Message = TempData["NotificationMessage"]?.ToString()
                };
            }

            var vm = new HomePageVM();
            vm.Categories = _productServices.GetAllCategories() ?? new List<Category>();

            var all = (_productServices.GetAllProducts() ?? new List<Product>())
                      .Where(p => p.IsActive && !p.IsDeleted)
                      .OrderByDescending(p => p.ModifiedDate)
                      .ToList();

            vm.Featured = all.Take(3).ToList();
            vm.BestSellers = all.OrderByDescending(p => p.Price).Take(4).ToList();
            vm.MoreProducts = all.Skip(4).Take(12).ToList();

            return View(vm);
        }
        [HttpGet("about-us")]
        public IActionResult About() => View();
        public IActionResult Test() => View();
        public IActionResult Privacy() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
            => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
