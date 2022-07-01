using GameHelperApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Services;

public class MemoryService: IServices<Memory>
{
    private readonly AppDbContext _context;
    
    public MemoryService(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Memory>> GetAllAsync()
    {
        var result = await _context.Memory.ToListAsync();
        return result;
    }

    public async Task<Memory> GetByIdAsync(int id)
    {
        var result = await _context.Memory.FirstOrDefaultAsync(x => x.MemoryId == id);
        return result;
    }

    public async Task AddAsync(Memory t)
    {
        await _context.Memory.AddAsync(t);
        await _context.SaveChangesAsync();
    }

    public async Task<Memory> UpdateAsync(int id, Memory newt)
    {
        _context.Update(newt);
        await _context.SaveChangesAsync();
        return newt;
    }

    public async Task DeleteAsync(int id)
    {
        var result = await _context.Memory.FirstOrDefaultAsync(x => x.MemoryId == id);
        _context.Memory.Remove(result);
        await _context.SaveChangesAsync();
    }
}