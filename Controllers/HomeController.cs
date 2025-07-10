using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Prn222Project.Models;
using Prn222Project.ViewModels;
namespace Prn222Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
