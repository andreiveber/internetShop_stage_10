using Microsoft.AspNetCore.Mvc;

namespace InternetShop.ViewComponents
{
    public class AdvantagesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var advantages = new List<string>
            {
                "Более 10000 товаров",
                "Быстро, качественно и с гарантией активируем подписки PlayStation Plus, Xbox Game Pass",
                "100% гарантия возврата денег",
                "Реальная экономия - скидки до 80%"
            };
            return View(advantages);
        }
    }
}