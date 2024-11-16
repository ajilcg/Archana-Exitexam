using Microsoft.EntityFrameworkCore;
using WebApplication4.Models.Entities;
namespace WebApplication4.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Book> Books { get; set; }

    }
}
