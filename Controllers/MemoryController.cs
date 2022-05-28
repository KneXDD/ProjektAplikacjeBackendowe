using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Controllers;

public class MemoryController : Controller
{
    private readonly AppDbContext _context;

    public MemoryController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _context.Memory.ToListAsync();
        return View();
    }
}