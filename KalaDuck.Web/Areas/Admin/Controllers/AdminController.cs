using Microsoft.AspNetCore.Mvc;

namespace KalaDuck.Web.Areas.Admin.Controllers;

[Area("Admin")]
public class AdminController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
