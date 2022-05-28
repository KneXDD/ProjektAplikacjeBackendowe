using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Controllers;

public class PsuController : Controller
{
    private readonly AppDbContext _context;

    public PsuController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _context.Psu.ToListAsync();
        return View();
    }
}