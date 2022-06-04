using GameHelperApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Services;

public class GpuService: IServices<Gpu>
{
    private readonly AppDbContext _context;
    
    public GpuService(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Gpu>> GetAllAsync()
    {
        var result = await _context.Gpu.ToListAsync();
        return result;
    }

    public async Task<Gpu> GetByIdAsync(int id)
    {
        var result = await _context.Gpu.FirstOrDefaultAsync(x => x.GpuId == id);
        return result;
    }

    public async Task AddAsync(Gpu t)
    {
        await _context.Gpu.AddAsync(t);
        await _context.SaveChangesAsync();
    }

    public async Task<Gpu> UpdateAsync(int id, Gpu newt)
    {
        _context.Update(newt);
        await _context.SaveChangesAsync();
        return newt;
    }

    public async Task DeleteAsync(int id)
    {
        var result = await _context.Gpu.FirstOrDefaultAsync(x => x.GpuId == id);
        _context.Gpu.Remove(result);
        await _context.SaveChangesAsync();
    }
}