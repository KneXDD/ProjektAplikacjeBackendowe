using GameHelperApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Services;

public class StudiosService: IServices<Studios>
{
    private readonly AppDbContext _context;
    
    public StudiosService(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Studios>> GetAllAsync()
    {
        var result = await _context.Studios.ToListAsync();
        return result;
    }

    public async Task<Studios> GetByIdAsync(int id)
    {
        var result = await _context.Studios.FirstOrDefaultAsync(x => x.StudioId == id);
        return result;
    }

    public async Task AddAsync(Studios t)
    {
        await _context.Studios.AddAsync(t);
        await _context.SaveChangesAsync();
    }

    public async Task<Studios> UpdateAsync(int id, Studios newt)
    {
        _context.Update(newt);
        await _context.SaveChangesAsync();
        return newt;
    }

    public async Task DeleteAsync(int id)
    {
        var result = await _context.Studios.FirstOrDefaultAsync(x => x.StudioId == id);
        _context.Studios.Remove(result);
        await _context.SaveChangesAsync();
    }
}