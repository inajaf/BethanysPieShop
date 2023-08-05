using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.ViewModels
{
    public class ShoppingCartViewModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
