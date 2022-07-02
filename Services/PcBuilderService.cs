using GameHelperApp.Models;
using GameHelperApp.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Services;

public class PcBuilderService: IPcBuilderService
{
    private readonly AppDbContext _context;
    
    public PcBuilderService(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<PcBuilder>> GetAllAsync()
    {
        var result = await _context.PcBuilder.Include(a => a.Cpu).Include(a => a.Motherboard).Include(a => a.Memory).Include(a => a.Storge).Include(a => a.Gpu).Include(a => a.Case).Include(a => a.Psu).ToListAsync();
        return result;
    }

    public async Task<PcBuilder> GetByIdAsync(int id)
    {
        var result = await _context.PcBuilder.Include(a => a.Cpu).Include(a => a.Motherboard).Include(a => a.Memory).Include(a => a.Storge).Include(a => a.Gpu).Include(a => a.Case).Include(a => a.Psu).FirstOrDefaultAsync(x => x.PcBuilderId == id);
        return result;
    }

    public async Task AddAsync(AddPcViewModel t)
    {
        var newPc = new PcBuilder()
        {
            CpuId = t.CpuId,
            MotherboardId = t.MotherboardId,
            MemoryId = t.MemoryId,
            StorgeId = t.StorgeId,
            GpuId = t.GpuId,
            CaseId = t.CaseId,
            PsuId = t.PsuId,
            Description = t.Description
        };
        await _context.PcBuilder.AddAsync(newPc);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(AddPcViewModel newt)
    {
        var result = await _context.PcBuilder.FirstOrDefaultAsync(n => n.PcBuilderId == newt.PcBuilderId);
        if (result != null)
        {
            result.CpuId = newt.CpuId;
            result.MotherboardId = newt.MotherboardId;
            result.MemoryId = newt.MemoryId;
            result.StorgeId = newt.StorgeId;
            result.GpuId = newt.GpuId;
            result.CaseId = newt.CaseId;
            result.PsuId = newt.PsuId;
            result.Description = newt.Description;
            await _context.SaveChangesAsync();
        }
        await _context.SaveChangesAsync();
        
    }

    public async Task DeleteAsync(int id)
    {
        var result = await _context.PcBuilder.Include(a => a.Cpu).Include(a => a.Motherboard).Include(a => a.Memory).Include(a => a.Storge).Include(a => a.Gpu).Include(a => a.Case).Include(a => a.Psu).FirstOrDefaultAsync(x => x.PcBuilderId == id);
        _context.PcBuilder.Remove(result);
        await _context.SaveChangesAsync();
    }

    public async Task<PcBuilderViewMode> PcBuilderViewMode()
    {
        var result = new PcBuilderViewMode();

        result.Cpu = await _context.Cpu.OrderBy(n => n.CpuModel).ToListAsync();
        result.Motherboard = await _context.Motherboard.OrderBy(n => n.MotherboardName).ToListAsync();
        result.Memory = await _context.Memory.OrderBy(n => n.MemoryName).ToListAsync();
        result.Storge = await _context.Storge.OrderBy(n => n.StorgeName).ToListAsync();
        result.Gpu = await _context.Gpu.OrderBy(n => n.GpuModel).ToListAsync();
        result.Case = await _context.Case.OrderBy(n => n.Name).ToListAsync();
        result.Psu = await _context.Psu.OrderBy(n => n.PsuModel).ToListAsync();
        return result;
    }
}