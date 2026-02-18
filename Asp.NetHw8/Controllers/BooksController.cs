using Asp.NetHw8.Interfaces;
using Asp.NetHw8.Models;
using Asp.NetHw8.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetHw8.Controllers
{
    public class BooksController(IBookService service) : Controller
    {
        public IActionResult Index()
        {
            return View(service.GetAll().Select(book => new BookViewModel(book.Title, book.Author, book.Genre, book.Year)));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookViewModel book)
        {
            service.Add(book.ToBook());
            return RedirectToAction(nameof(Index));
        }
    }
}
