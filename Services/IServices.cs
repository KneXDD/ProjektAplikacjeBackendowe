using GameHelperApp.Models;

namespace GameHelperApp.Services;

public interface IServices<T>
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task AddAsync(T t);
    Task<T> UpdateAsync(int id, T newt);
    Task DeleteAsync(int id);
}