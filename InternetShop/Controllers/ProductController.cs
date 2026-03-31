using Microsoft.AspNetCore.Mvc;
using InternetShop.Models;
using InternetShop.Services;

namespace InternetShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Title"] = "Добавление товара";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                TempData["SuccessMessage"] = "Товар успешно добавлен!";
                return RedirectToAction("Products", "Home");
            }

            return View(product);
        }
    }
}