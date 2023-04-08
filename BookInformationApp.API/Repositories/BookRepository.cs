using BookInformationApp.API.Data;
using BookInformationApp.API.Domain_Entities;
using BookInformationApp.API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BookInformationApp.API.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        private readonly BookInfoAppDBContext _context;

        public BookRepository(BookInfoAppDBContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<IReadOnlyList<Book>> GetBooksByGenreAsync(string genre)
        {
            return await _context.Books.Where(b => b.Genre.ToLower() == genre.ToLower()).ToListAsync();
        }
    }
}
