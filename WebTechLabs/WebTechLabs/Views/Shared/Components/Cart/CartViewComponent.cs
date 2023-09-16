using Microsoft.AspNetCore.Mvc;

namespace WebTechLabs.Views.Shared.Components.Cart
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
