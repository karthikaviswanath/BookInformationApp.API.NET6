using BookInformationApp.API.Data.Configurations;
using BookInformationApp.API.Data.Domain_Entities;
using BookInformationApp.API.Domain_Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookInformationApp.API.Data
{
    public class BookInfoAppDBContext : IdentityDbContext<BookApiUser>
    {
        public BookInfoAppDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }
    }
}
