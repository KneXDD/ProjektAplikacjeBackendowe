using GameHelperApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Services;

public class CaseService: IServices<Case>
{
    private readonly AppDbContext _context;
    
    public CaseService(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Case>> GetAllAsync()
    {
        var result = await _context.Case.ToListAsync();
        return result;
    }

    public async Task<Case> GetByIdAsync(int id)
    {
        var result = await _context.Case.FirstOrDefaultAsync(x => x.CaseId == id);
        return result;
    }

    public async Task AddAsync(Case t)
    {
        await _context.Case.AddAsync(t);
        await _context.SaveChangesAsync();
    }

    public async Task<Case> UpdateAsync(int id, Case newt)
    {
        _context.Update(newt);
        await _context.SaveChangesAsync();
        return newt;
    }

    public async Task DeleteAsync(int id)
    {
        var result = await _context.Case.FirstOrDefaultAsync(x => x.CaseId == id);
        _context.Case.Remove(result);
        await _context.SaveChangesAsync();
    }
}