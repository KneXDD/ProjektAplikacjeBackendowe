using GameHelperApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Services;

public class StorgeService: IServices<Storge>
{
    private readonly AppDbContext _context;
    
    public StorgeService(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Storge>> GetAllAsync()
    {
        var result = await _context.Storge.ToListAsync();
        return result;
    }

    public async Task<Storge> GetByIdAsync(int id)
    {
        var result = await _context.Storge.FirstOrDefaultAsync(x => x.StorgeId == id);
        return result;
    }

    public async Task AddAsync(Storge t)
    {
        await _context.Storge.AddAsync(t);
        await _context.SaveChangesAsync();
    }

    public async Task<Storge> UpdateAsync(int id, Storge newt)
    {
        _context.Update(newt);
        await _context.SaveChangesAsync();
        return newt;
    }

    public async Task DeleteAsync(int id)
    {
        var result = await _context.Storge.FirstOrDefaultAsync(x => x.StorgeId == id);
        _context.Storge.Remove(result);
        await _context.SaveChangesAsync();
    }
}