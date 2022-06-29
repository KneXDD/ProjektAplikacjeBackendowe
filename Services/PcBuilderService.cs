using GameHelperApp.Models;
using GameHelperApp.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Services;

public class PcBuilderService: IPcBuilderService<PcBuilder>
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

    public async Task<PcBuilderViewMode> PcBuilderViewMode()
    {
        var result = new PcBuilderViewMode()
        {
            Cpu = await _context.Cpu.OrderBy(n => n.CpuModel).ToListAsync(),
            Motherboard = await _context.Motherboard.OrderBy(n => n.MotherboardName).ToListAsync(),
            Memory = await _context.Memory.OrderBy(n => n.MemoryName).ToListAsync(),
            Storge = await _context.Storge.OrderBy(n => n.StorgeName).ToListAsync(),
            Gpu = await _context.Gpu.OrderBy(n => n.GpuModel).ToListAsync(),
            Case = await _context.Case.OrderBy(n => n.Name).ToListAsync(),
            Psu = await _context.Psu.OrderBy(n => n.PsuModel).ToListAsync()
        };
        return result;
    }
}