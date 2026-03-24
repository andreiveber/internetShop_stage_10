using Microsoft.AspNetCore.Mvc;
using InternetShop.Models;
using InternetShop.Services;
using InternetShop.ViewModels;

namespace InternetShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductService _productService;

        public HomeController(ProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Главная";
            var viewModel = _productService.GetHomeViewModel();
            return View(viewModel);
        }

        [Route("catalog")]
        [Route("Home/Products")]
        public IActionResult Products()
        {
            ViewData["Title"] = "Товары";
            var products = _productService.GetAllProducts();
            return View(products);
        }

        [Route("product/{id:int}")]
        public IActionResult ProductDetails(int id)
        {
            ViewData["Title"] = $"Товар #{id}";
            var product = _productService.GetProductById(id);

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
            var viewModel = _productService.GetContactViewModel(name);
            return View(viewModel);
        }

        [Route("about")]
        public IActionResult About()
        {
            ViewData["Title"] = "О нас";
            return View();
        }
    }
}