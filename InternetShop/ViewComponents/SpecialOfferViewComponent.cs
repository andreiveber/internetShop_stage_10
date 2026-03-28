using Microsoft.AspNetCore.Mvc;

namespace InternetShop.ViewComponents
{
    public class SpecialOfferViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var offer = new
            {
                Title = "Специальное предложение!",
                Description = "При покупке любого товара от 500р идёт целых 3 ПОДАРКА НА ВАШ ВЫБОР, один из которых наушники Monster Beats!",
                ButtonText = "Перейти к покупкам",
                ButtonUrl = "/Home/Products"
            };
            return View(offer);
        }
    }
}