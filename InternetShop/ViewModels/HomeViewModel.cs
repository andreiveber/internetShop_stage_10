namespace InternetShop.ViewModels
{
    public class HomeViewModel
    {
        public string WelcomeMessage { get; set; } = string.Empty;
        public List<ProductViewModel> FeaturedProducts { get; set; } = new();
        public int TotalProducts { get; set; }
        public string SpecialOffer { get; set; } = string.Empty;
    }
}