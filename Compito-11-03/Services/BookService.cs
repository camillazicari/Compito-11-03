using Compito_11_03.Data;
using Compito_11_03.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Compito_11_03.Services
{
    public class BookService
    {
        private readonly Compito1103DbContext _context;

        public BookService(Compito1103DbContext context)
        {
            _context = context;
        }

        public async Task<BookViewModel> GetAllBooksAsync()
        {
            try
            {
                var booksList = new BookViewModel();

                booksList.Books = await _context.Books.ToListAsync();

                return booksList;
            }
            catch
            {
                return new BookViewModel() { Books = new() };
            }
        }
    }
}

