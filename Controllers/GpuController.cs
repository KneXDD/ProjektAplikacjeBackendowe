using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Controllers;

public class GpuController : Controller
{
    private readonly AppDbContext _context;

    public GpuController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _context.Gpu.ToListAsync();
        return View();
    }
}