using Microsoft.AspNetCore.Mvc;

namespace MusicShop.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
