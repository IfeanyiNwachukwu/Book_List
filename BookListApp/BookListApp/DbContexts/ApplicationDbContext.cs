using BookListApp.Model;
using Microsoft.EntityFrameworkCore;

namespace BookListApp.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
