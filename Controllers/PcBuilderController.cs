using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Controllers;

public class PcBuilderController : Controller
{
    private readonly AppDbContext _context;

    public PcBuilderController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _context.PcBuilder.ToListAsync();
        return View();
    }
}