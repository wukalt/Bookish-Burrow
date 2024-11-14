using BookishBurrow.DataAccess.Interfaces;
using BookishBurrow.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookishBurrow.Web.Areas.Admin.Controllers;

public class BookController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public BookController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IActionResult> Index()
    {
        var books = await _unitOfWork.Book.GetAll();
        return View(books);
    }

    public async Task<IActionResult> Upsert(int id)
    {
        if (id > 0)
        {
            var book = await _unitOfWork.Book.Get(id);
            if (book is null)
            {
                return NotFound();
            }
            return View(book);
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
    public async Task<IActionResult> Upsert(Book? book)
    {
        if (book is null)
        {
            return BadRequest();
        }

        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        else if (book.Id is 0) //it's a new record
        {
            await _unitOfWork.Book.Add(book);
        }

        else
        {
            await _unitOfWork.Book.Update(book);
        }
        await _unitOfWork.Commit();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> Remove(int id)
    {
        var book = await _unitOfWork.Book.Get(id);
        if (book is null)
        {
            return NotFound();
        }
        await _unitOfWork.Book.Remove(book);
        await _unitOfWork.Commit();
        return RedirectToAction("Index");
    }
}
