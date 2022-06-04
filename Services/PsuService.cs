using GameHelperApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Services;

public class PsuService: IServices<Psu>
{
    private readonly AppDbContext _context;
    
    public PsuService(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Psu>> GetAllAsync()
    {
        var result = await _context.Psu.ToListAsync();
        return result;
    }

    public async Task<Psu> GetByIdAsync(int id)
    {
        var result = await _context.Psu.FirstOrDefaultAsync(x => x.PsuId == id);
        return result;
    }

    public async Task AddAsync(Psu t)
    {
        await _context.Psu.AddAsync(t);
        await _context.SaveChangesAsync();
    }

    public async Task<Psu> UpdateAsync(int id, Psu newt)
    {
        _context.Update(newt);
        await _context.SaveChangesAsync();
        return newt;
    }

    public async Task DeleteAsync(int id)
    {
        var result = await _context.Psu.FirstOrDefaultAsync(x => x.PsuId == id);
        _context.Psu.Remove(result);
        await _context.SaveChangesAsync();
    }
}