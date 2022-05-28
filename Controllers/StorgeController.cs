using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Controllers;

public class StorgeController : Controller
{
    private readonly AppDbContext _context;

    public StorgeController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _context.Storge.ToListAsync();
        return View();
    }
}