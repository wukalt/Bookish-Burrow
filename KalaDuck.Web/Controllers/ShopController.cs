using Microsoft.AspNetCore.Mvc;

namespace KalaDuck.Web.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
