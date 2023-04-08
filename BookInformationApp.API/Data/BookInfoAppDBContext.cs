using BookInformationApp.API.Domain_Entities;
using Microsoft.EntityFrameworkCore;

namespace BookInformationApp.API.Data
{
    public class BookInfoAppDBContext : DbContext
    {
        public BookInfoAppDBContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
    }
}
