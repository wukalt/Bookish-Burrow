using BookishBurrow.DataAccess.Interfaces;
using BookishBurrow.Models;
using BookishBurrow.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookishBurrow.Web.Areas.Users.Controllers;

[Area("Users")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUnitOfWork _unitOfWork;

    public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;
    }

    public async Task<IActionResult> Index()
    {
        IEnumerable<Book> books = await _unitOfWork.Book.GetAll(6);
        return View(books);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult ContactUs()
    {
        return View();
    }

    public IActionResult AboutUs()
    {
        return View();
    }
}
