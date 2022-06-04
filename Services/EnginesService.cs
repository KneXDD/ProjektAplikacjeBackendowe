using GameHelperApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Services;

public class EnginesService: IServices<Engines>
{
    private readonly AppDbContext _context;
    
    public EnginesService(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Engines>> GetAllAsync()
    {
        var result = await _context.Engines.ToListAsync();
        return result;
    }

    public async Task<Engines> GetByIdAsync(int id)
    {
        var result = await _context.Engines.FirstOrDefaultAsync(x => x.EngineId == id);
        return result;
    }

    public async Task AddAsync(Engines t)
    {
        await _context.Engines.AddAsync(t);
        await _context.SaveChangesAsync();
    }

    public async Task<Engines> UpdateAsync(int id, Engines newt)
    {
        _context.Update(newt);
        await _context.SaveChangesAsync();
        return newt;
    }

    public async Task DeleteAsync(int id)
    {
        var result = await _context.Engines.FirstOrDefaultAsync(x => x.EngineId == id);
        _context.Engines.Remove(result);
        await _context.SaveChangesAsync();
    }
}