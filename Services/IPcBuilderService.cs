using GameHelperApp.Models;
using GameHelperApp.ViewModel;

namespace GameHelperApp.Services;

public interface IPcBuilderService<PcBuilder>
{
    Task<IEnumerable<PcBuilder>> GetAllAsync();
    Task<PcBuilder> GetByIdAsync(int id);
    Task AddAsync(PcBuilder t);
    Task<PcBuilder> UpdateAsync(int id, PcBuilder newt);
    Task DeleteAsync(int id);
    Task<PcBuilderViewMode> PcBuilderViewMode();
}