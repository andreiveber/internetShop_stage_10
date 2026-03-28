using Microsoft.AspNetCore.Mvc;

namespace InternetShop.ViewComponents
{
    public class BreadcrumbViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var currentUrl = ViewContext.HttpContext.Request.Path.ToString();
            var segments = currentUrl.Split('/', StringSplitOptions.RemoveEmptyEntries);

            var breadcrumbs = new List<(string Title, string Url)>();
            breadcrumbs.Add(("Главная", "/"));

            string accumulatedPath = "";
            foreach (var segment in segments)
            {
                accumulatedPath += "/" + segment;
                var title = segment switch
                {
                    "Home" => "Главная",
                    "Products" => "Товары",
                    "Contact" => "Контакты",
                    "About" => "О нас",
                    "admin" => "Админка",
                    "dashboard" => "Панель управления",
                    "stats" => "Статистика",
                    _ => segment
                };
                breadcrumbs.Add((title, accumulatedPath));
            }

            return View(breadcrumbs);
        }
    }
}