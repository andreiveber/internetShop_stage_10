using Microsoft.AspNetCore.Mvc;

namespace InternetShop.ViewComponents
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories = new List<(string Name, string Url)>
            {
                ("Игры для PS5", "/catalog?category=ps5"),
                ("Игры для Xbox", "/catalog?category=xbox"),
                ("Игровые консоли", "/catalog?category=consoles"),
                ("Аксессуары", "/catalog?category=accessories")
            };
            return View(categories);
        }
    }
}