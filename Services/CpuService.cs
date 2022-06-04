using GameHelperApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Services;

public class CpuService: IServices<Cpu>
{
    private readonly AppDbContext _context;
    
    public CpuService(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Cpu>> GetAllAsync()
    {
        var result = await _context.Cpu.ToListAsync();
        return result;
    }

    public async Task<Cpu> GetByIdAsync(int id)
    {
        var result = await _context.Cpu.FirstOrDefaultAsync(x => x.CpuId == id);
        return result;
    }

    public async Task AddAsync(Cpu t)
    {
        await _context.Cpu.AddAsync(t);
        await _context.SaveChangesAsync();
    }

    public async Task<Cpu> UpdateAsync(int id, Cpu newt)
    {
        _context.Update(newt);
        await _context.SaveChangesAsync();
        return newt;
    }

    public async Task DeleteAsync(int id)
    {
        var result = await _context.Cpu.FirstOrDefaultAsync(x => x.CpuId == id);
        _context.Cpu.Remove(result);
        await _context.SaveChangesAsync();
    }
}