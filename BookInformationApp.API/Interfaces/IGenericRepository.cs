namespace BookInformationApp.API.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
        Task<bool> Exists(int id);
    }
}
