using GameHelperApp.Models;
using GameHelperApp.ViewModel;

namespace GameHelperApp.Services;

public interface IGameService
{
    Task<IEnumerable<Games>> GetAllAsync();
    Task<Games> GetByIdAsync(int id);
    Task AddAsync(AddGameViewModel t);
    Task UpdateAsync(AddGameViewModel newt);
    Task DeleteAsync(int id);
    Task<GamesViewModel> GetGameViewModel();
}