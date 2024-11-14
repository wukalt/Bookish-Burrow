using BookishBurrow.DataAccess.Interfaces;
using BookishBurrow.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookishBurrow.Web.Areas.Admin.Controllers;

public class UserController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public UserController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IActionResult> Index()
    {
        var users = await _unitOfWork.User.GetAll();
        return View(users);
    }

    public async Task<IActionResult> Upsert(int id)
    {
        if (id > 0)
        {
            var user = await _unitOfWork.User.Get(id);
            if (user is null)
            {
                return NotFound();
            }
            return View(user);
        }

        else if (id is 0)
        {
            return View();
        }

        else
        {
            return BadRequest();
        }
    }

    [HttpPost]
    public async Task<IActionResult> Upsert(ApplicationUser? user)
    {
        if (user is null)
        {
            return BadRequest();
        }

        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        else if (user.Id == string.Empty) //it's a new record
        {
            await _unitOfWork.User.Add(user);
        }

        else
        {
            await _unitOfWork.User.Update(user);
        }
        await _unitOfWork.Commit();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> Remove(string id)
    {
        var user = await _unitOfWork.User.Get(id);
        if (user is null)
        {
            return NotFound();
        }
        await _unitOfWork.User.Remove(user);
        await _unitOfWork.Commit();
        return RedirectToAction("Index");
    }
}
