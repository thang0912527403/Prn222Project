using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Prn222Project.Controllers
{
    [Authorize]
    [Route("Dashboard")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
