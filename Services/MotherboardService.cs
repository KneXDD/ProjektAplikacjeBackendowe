using GameHelperApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Services;

public class MotherboardService: IServices<Motherboard>
{
    private readonly AppDbContext _context;
    
    public MotherboardService(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Motherboard>> GetAllAsync()
    {
        var result = await _context.Motherboard.ToListAsync();
        return result;
    }

    public async Task<Motherboard> GetByIdAsync(int id)
    {
        var result = await _context.Motherboard.FirstOrDefaultAsync(x => x.MotherboardId == id);
        return result;
    }

    public async Task AddAsync(Motherboard t)
    {
        await _context.Motherboard.AddAsync(t);
        await _context.SaveChangesAsync();
    }

    public async Task<Motherboard> UpdateAsync(int id, Motherboard newt)
    {
        _context.Update(newt);
        await _context.SaveChangesAsync();
        return newt;
    }

    public async Task DeleteAsync(int id)
    {
        var result = await _context.Motherboard.FirstOrDefaultAsync(x => x.MotherboardId == id);
        _context.Motherboard.Remove(result);
        await _context.SaveChangesAsync();
    }
}