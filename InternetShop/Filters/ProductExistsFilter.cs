using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using InternetShop.Services;

namespace InternetShop.Filters
{
    public class ProductExistsFilter : IActionFilter
    {
        private readonly ProductService _productService;

        public ProductExistsFilter(ProductService productService)
        {
            _productService = productService;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ActionArguments.ContainsKey("id"))
            {
                var id = (int)context.ActionArguments["id"]!;
                var product = _productService.GetProductById(id);

                if (product == null)
                {
                    context.Result = new RedirectToActionResult("Error404", "Home", null);
                }
            }
        }

        public void OnActionExecuted(ActionExecutedContext context) { }
    }
}