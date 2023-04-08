using BookInformationApp.API.Domain_Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookInformationApp.API.Data.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book
                {
                    Id = 1,
                    Title = "The Adventures of Tom Sawyer",
                    Language = "English",
                    Description = "This novel centres on a smart mischievous young boy living in a town along the Mississippi River.",
                    Genre = "Fiction",
                    AuthorName = "Mark Twain",
                    Pages=244,
                    PublishedDate = new DateTime(1876,6,1) 
                },
                new Book
                {
                    Id = 2,
                    Title = "The Murder of Roger Ackroyd",
                    Language = "English",
                    Description = "Considered to be one of Agatha Christie's greatest, and also most controversial mysteries.",
                    Genre = "Mystery Thriller",
                    AuthorName = "Agatha Christie",
                    Pages = 288,
                    PublishedDate = new DateTime(1926, 6, 7)
                });
        }
    }
}
