using GameHelperApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Services;

public class PcBuilderService: IServices<PcBuilder>
{
    private readonly AppDbContext _context;
    
    public PcBuilderService(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<PcBuilder>> GetAllAsync()
    {
        var result = await _context.PcBuilder.ToListAsync();
        return result;
    }

    public async Task<PcBuilder> GetByIdAsync(int id)
    {
        var result = await _context.PcBuilder.FirstOrDefaultAsync(x => x.PcBuilderId == id);
        return result;
    }

    public async Task AddAsync(PcBuilder t)
    {
        await _context.PcBuilder.AddAsync(t);
        await _context.SaveChangesAsync();
    }

    public async Task<PcBuilder> UpdateAsync(int id, PcBuilder newt)
    {
        _context.Update(newt);
        await _context.SaveChangesAsync();
        return newt;
    }

    public async Task DeleteAsync(int id)
    {
        var result = await _context.PcBuilder.FirstOrDefaultAsync(x => x.PcBuilderId == id);
        _context.PcBuilder.Remove(result);
        await _context.SaveChangesAsync();
    }
}