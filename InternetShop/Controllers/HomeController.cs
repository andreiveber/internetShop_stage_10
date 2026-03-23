using Microsoft.AspNetCore.Mvc;
using InternetShop.Models;

namespace InternetShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Главная";
            return View();
        }

        [Route("catalog")]
        [Route("Home/Products")]
        public IActionResult Products()
        {
            ViewData["Title"] = "Товары";

            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Assassin's Creed : Shadows", Price = 4990M, Description = "Игра для PS5" },
                new Product { Id = 2, Name = "Astro bot", Price = 4590M, Description = "Игра для PS5" },
                new Product { Id = 3, Name = "Cyberpunk 2077: Ultimate Edition", Price = 3990M, Description = "Игра для PS5" },
                new Product { Id = 4, Name = "Sony Playstation 5 Pro", Price = 70690M, Description = "Игровая приставка" },
                new Product { Id = 5, Name = "Xbox Series X", Price = 59790M, Description = "Игровая консоль" }
            };

            return View(products);
        }

        [Route("product/{id:int}")]
        public IActionResult ProductDetails(int id)
        {
            ViewData["Title"] = $"Товар #{id}";

            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Assassin's Creed : Shadows", Price = 4990M, Description = "Игра для PS5" },
                new Product { Id = 2, Name = "Astro bot", Price = 4590M, Description = "Игра для PS5" },
                new Product { Id = 3, Name = "Cyberpunk 2077: Ultimate Edition", Price = 3990M, Description = "Игра для PS5" },
                new Product { Id = 4, Name = "Sony Playstation 5 Pro", Price = 70690M, Description = "Игровая приставка" },
                new Product { Id = 5, Name = "Xbox Series X", Price = 59790M, Description = "Игровая консоль" }
            };

            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [Route("contact")]
        [Route("Home/Contact")]
        [Route("feedback/{name?}")]
        public IActionResult Contact(string name = null)
        {
            ViewData["Title"] = "Контакты";
            ViewBag.UserName = name;
            return View();
        }

        [Route("about")]
        public IActionResult About()
        {
            ViewData["Title"] = "О нас";
            return View();
        }
    }
}