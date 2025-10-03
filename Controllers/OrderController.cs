using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prn222Project.Data;
using System.Security.Claims;
namespace Prn222Project.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _db;
        public OrderController(ApplicationDbContext db) => _db = db;

        // /Orders
        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;

            var orders = await _db.Orders
                .Where(o => o.UserId == userId)
                .Include(o => o.OrderDetails)
                .OrderByDescending(o => o.order_date)
                .ToListAsync();

            return View(orders);
        }

        // /Orders/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;

            var order = await _db.Orders
                .Where(o => o.UserId == userId && o.order_id == id)
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.ProductVariant)
                        .ThenInclude(pv => pv.Product)
                .FirstOrDefaultAsync();

            if (order == null) return NotFound(); 

            return View(order);
        }
    }
}
