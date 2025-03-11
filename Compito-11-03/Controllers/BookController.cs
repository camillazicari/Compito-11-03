using Compito_11_03.Services;
using Microsoft.AspNetCore.Mvc;

namespace Compito_11_03.Controllers
{
    public class BookController : Controller
    {
        private readonly BookService _bookService;

        public BookController(BookService bookService)
        {
            this._bookService = bookService;
        }
        public async Task<IActionResult> Index()
        {
            var bookList = await _bookService.GetAllBooksAsync();

            return View(bookList);
        }
    }
}
