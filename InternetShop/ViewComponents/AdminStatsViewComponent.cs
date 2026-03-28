using Microsoft.AspNetCore.Mvc;

namespace InternetShop.ViewComponents
{
    public class AdminStatsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var stats = new
            {
                TotalProducts = 5,
                TotalOrders = 128,
                TotalRevenue = 125000,
                ActiveUsers = 42
            };
            return View(stats);
        }
    }
}