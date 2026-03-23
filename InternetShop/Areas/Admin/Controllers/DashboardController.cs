using Microsoft.AspNetCore.Mvc;

namespace InternetShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]")]
    public class DashboardController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewData["Title"] = "Панель администратора";
            return View();
        }

        [Route("stats")]
        public IActionResult Stats()
        {
            ViewData["Title"] = "Статистика";

            var stats = new
            {
                TotalProducts = 5,
                TotalOrders = 128,
                TotalRevenue = 125000,
                ActiveUsers = 42
            };

            return View(stats);
        }

        [Route("product/{id:int}")]
        public IActionResult ProductDetails(int id)
        {
            ViewData["Title"] = $"Товар #{id}";
            ViewBag.ProductId = id;
            return View();
        }
    }
}