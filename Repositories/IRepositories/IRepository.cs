using System.Collections;
using System.Linq.Expressions;

namespace FinprintProject.Repository.IRepository
{
    public interface IRepository<T> where T: class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetbyIdAsync(int id);
        T GetByFilter(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
