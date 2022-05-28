using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Controllers;

public class CpuController : Controller
{
    private readonly AppDbContext _context;

    public CpuController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _context.Case.ToListAsync();
        return View();
    }
}