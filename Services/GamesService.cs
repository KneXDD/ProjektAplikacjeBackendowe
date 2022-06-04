using GameHelperApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Services;

public class GamesService: IServices<Games>
{
    private readonly AppDbContext _context;
    
    public GamesService(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Games>> GetAllAsync()
    {
        var result = await _context.Games.ToListAsync();
        return result;
    }

    public async Task<Games> GetByIdAsync(int id)
    {
        var result = await _context.Games.FirstOrDefaultAsync(x => x.GameId == id);
        return result;
    }

    public async Task AddAsync(Games t)
    {
        await _context.Games.AddAsync(t);
        await _context.SaveChangesAsync();
    }

    public async Task<Games> UpdateAsync(int id, Games newt)
    {
        _context.Update(newt);
        await _context.SaveChangesAsync();
        return newt;
    }

    public async Task DeleteAsync(int id)
    {
        var result = await _context.Games.FirstOrDefaultAsync(x => x.GameId == id);
        _context.Games.Remove(result);
        await _context.SaveChangesAsync();
    }
}