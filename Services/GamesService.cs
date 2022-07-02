using GameHelperApp.Models;
using GameHelperApp.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace GameHelperApp.Services;

public class GamesService: IGameService
{
    private readonly AppDbContext _context;
    
    public GamesService(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Games>> GetAllAsync()
    {
        var result = await _context.Games.Include(a => a.Studios).Include(a => a.Engines).ToListAsync();
        return result;
    }

    public async Task<Games> GetByIdAsync(int id)
    {
        var result = await _context.Games.Include(a => a.Studios).Include(a => a.Engines).FirstOrDefaultAsync(x => x.GameId == id);
        return result;
    }

    public async Task AddAsync(AddGameViewModel t)
    {
        var newGame = new Games()
        {
            Name = t.Name,
            Genre = t.Genre,
            ReleaseDate = t.ReleaseDate,
            Cover = t.Cover,
            StudioId = t.StudioId,
            EngineId = t.EngineId
        };
        await _context.Games.AddAsync(newGame);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(AddGameViewModel newt)
    {
        var result = await _context.Games.FirstOrDefaultAsync(n => n.GameId == newt.GameId);
        if (result != null)
        {
            result.Name = newt.Name;
            result.Genre = newt.Genre;
            result.ReleaseDate = newt.ReleaseDate;
            result.Cover = newt.Cover;
            result.StudioId = newt.StudioId;
            result.EngineId = newt.EngineId;
            await _context.SaveChangesAsync();
        }
        await _context.SaveChangesAsync();
        
    }

    public async Task DeleteAsync(int id)
    {
        var result = await _context.Games.Include(a => a.Studios).Include(a => a.Engines).FirstOrDefaultAsync(x => x.GameId == id);
        _context.Games.Remove(result);
        await _context.SaveChangesAsync();
    }

    public async Task<GamesViewModel> GetGameViewModel()
    {
        var result = new GamesViewModel()
        {
            Engine = await _context.Engines.OrderBy(n => n.Name).ToListAsync(),
            Studio = await _context.Studios.OrderBy(n => n.Name).ToListAsync()
        };
        return result;
    }
}