using KalaDuck.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KalaDuck.Web.Areas.Users.Controllers;

[Area("Users")]
public class ShopController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public ShopController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IActionResult> Index()
    {
        var products = await _unitOfWork.Book.GetAll();
        return View(products);
    }
}
