using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Controllers;

public class EnginesController : Controller
{
    private readonly AppDbContext _context;

    public EnginesController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _context.Engines.ToListAsync();
        return View();
    }
}