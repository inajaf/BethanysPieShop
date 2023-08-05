using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
