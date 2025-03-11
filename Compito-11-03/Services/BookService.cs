using Compito_11_03.Data;
using Compito_11_03.Models;
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

        private async Task<bool> SaveAsync()
        {
            try
            {
                var rowsAffected = await _context.SaveChangesAsync();

                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
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

        public async Task<bool> AddBookAsync(AddBookViewModel addBookViewModel)
        {
            var book = new Book()
            {
                Id = Guid.NewGuid(),
                Titolo = addBookViewModel.Titolo,
                Autore = addBookViewModel.Autore,
                Genere = addBookViewModel.Genere,
                Disponibilità = addBookViewModel.Disponibilità
            };

            _context.Books.Add(book);
            return await SaveAsync();

        }
    }
}

