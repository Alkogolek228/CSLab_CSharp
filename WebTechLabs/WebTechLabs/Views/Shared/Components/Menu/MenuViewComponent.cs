using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebTechLabs.Models;

namespace laba1.Components
{
    public class MenuViewComponent : ViewComponent
    {
        // Инициализация списка элементов меню
        private List<MenuItem> _menuItems = new List<MenuItem>
        {
            new MenuItem{ Controller="Home", Action="Index", Text="Lab 2"},
            new MenuItem{ Controller="Product", Action="Default", Text="Каталог"},
            new MenuItem{ IsPage=true, Area="Admin", Page="/Index", Text="Администрирование"}
        };

        public IViewComponentResult Invoke()
        {
            var controller = ViewContext.RouteData.Values["controller"];
            var page = ViewContext.RouteData.Values["page"];
            var area = ViewContext.RouteData.Values["area"];

            foreach (var item in _menuItems)
            {
                var matchController = controller?.Equals(item.Controller) ?? false;
                var matchArea = area?.Equals(item.Area) ?? false;

                if (matchController || matchArea)
                {
                    item.Active = "active";
                }
            }

            return View(_menuItems);
        }
    }
}
