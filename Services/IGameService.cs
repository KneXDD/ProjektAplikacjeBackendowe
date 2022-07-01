using GameHelperApp.ViewModel;

namespace GameHelperApp.Services;

public interface IGameService<Games>
{
    Task<IEnumerable<Games>> GetAllAsync();
    Task<Games> GetByIdAsync(int id);
    Task AddAsync(Games t);
    Task<Games> UpdateAsync(int id, Games newt);
    Task DeleteAsync(int id);
    Task<GamesViewModel> GetGameViewModel();
}