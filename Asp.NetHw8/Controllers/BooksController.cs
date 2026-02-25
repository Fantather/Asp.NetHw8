using Asp.NetHw8.Helpers;
using Asp.NetHw8.InputModels;
using Asp.NetHw8.Interfaces;
using Asp.NetHw8.Mappers;
using Asp.NetHw8.Models;
using Asp.NetHw8.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetHw8.Controllers
{
    public class BooksController(IBookService bookService) : Controller
    {
        public IActionResult Index(int? page)
        {
            int pageNumber = page ?? 1;
            int pageSize = 5;

            PaginatedList<Book> pagedBooks = PaginatedList<Book>.Create(bookService.GetAll(), pageNumber, pageSize);
            PaginatedList<BookViewModel> viewModels = pagedBooks
                .Select(book => book.ToViewModel());

            return View(viewModels);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookInputModel inputModel)
        {
            bookService.Add(await inputModel.ToBook());
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(Guid id) { 
            Book? targetBook = bookService.GetById(id);
            if (targetBook is null) 
                return NotFound();

            return View(targetBook.ToViewModel());
        }
    }
}
