using Compito_11_03.Models;
using Microsoft.EntityFrameworkCore;

namespace Compito_11_03.Data
{
    public class Compito1103DbContext : DbContext
    {
        public Compito1103DbContext(DbContextOptions<Compito1103DbContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
    }
}
