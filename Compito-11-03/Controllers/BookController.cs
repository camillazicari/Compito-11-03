using Compito_11_03.Services;
using Compito_11_03.ViewModels;
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

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddBookViewModel addBookViewModel)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Error while saving entity to database";
                return RedirectToAction("Index");
            }

            var result = await _bookService.AddBookAsync(addBookViewModel);
            if (!result)
            {
                TempData["Error"] = "Error while saving entity to database";
            }

            return RedirectToAction("Index");
        }
    }
}
