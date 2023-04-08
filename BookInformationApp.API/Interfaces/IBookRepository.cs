using BookInformationApp.API.Domain_Entities;

namespace BookInformationApp.API.Interfaces
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        Task<IReadOnlyList<Book>> GetBooksByGenreAsync(string genre);
    }
}
