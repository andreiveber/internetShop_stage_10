using InternetShop.Models;
using InternetShop.ViewModels;

namespace InternetShop.Services
{
    public class ProductService
    {
        private readonly List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Assassin's Creed : Shadows", Price = 4990M, Description = "Игра для PS5" },
            new Product { Id = 2, Name = "Astro bot", Price = 4590M, Description = "Игра для PS5" },
            new Product { Id = 3, Name = "Cyberpunk 2077: Ultimate Edition", Price = 3990M, Description = "Игра для PS5" },
            new Product { Id = 4, Name = "Sony Playstation 5 Pro", Price = 70690M, Description = "Игровая приставка" },
            new Product { Id = 5, Name = "Xbox Series X", Price = 59790M, Description = "Игровая консоль" }
        };

        public List<Product> GetAllProducts() => _products;

        public Product? GetProductById(int id) => _products.FirstOrDefault(p => p.Id == id);

        public List<ProductViewModel> GetProductViewModels()
        {
            return _products.Select(p => new ProductViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Description = p.Description,
                Category = p.Description.Contains("PS5") ? "PS5" : "Xbox",
                InStock = true,
                ImageUrl = "/images/placeholder.jpg"
            }).ToList();
        }

        public HomeViewModel GetHomeViewModel()
        {
            return new HomeViewModel
            {
                WelcomeMessage = "Добро пожаловать в наш специализированный игровой интернет-магазин SOTCOMM",
                FeaturedProducts = GetProductViewModels().Take(3).ToList(),
                TotalProducts = _products.Count,
                SpecialOffer = "При покупке любого товара от 500р идёт целых 3 ПОДАРКА НА ВАШ ВЫБОР"
            };
        }

        public ContactViewModel GetContactViewModel(string? userName = null)
        {
            return new ContactViewModel
            {
                Address = "г. Челябинск, ул. Воровского, 6 (ТРК «Урал» 3 этаж)",
                Phone = "8 (904) 933-99-11",
                Email = "sotcomm174@mail.ru",
                WorkingHours = "с 10-00 до 22-00",
                UserName = userName
            };
        }
    }
}