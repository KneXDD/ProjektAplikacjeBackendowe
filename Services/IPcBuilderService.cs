using GameHelperApp.Models;
using GameHelperApp.ViewModel;

namespace GameHelperApp.Services;

public interface IPcBuilderService
{
    Task<IEnumerable<PcBuilder>> GetAllAsync();
    Task<PcBuilder> GetByIdAsync(int id);
    Task AddAsync(AddPcViewModel t);
    Task UpdateAsync(AddPcViewModel newt);
    Task DeleteAsync(int id);
    Task<PcBuilderViewMode> PcBuilderViewMode();
}