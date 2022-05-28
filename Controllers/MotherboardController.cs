using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Controllers;

public class MotherboardController : Controller
{
    private readonly AppDbContext _context;

    public MotherboardController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _context.Motherboard.ToListAsync();
        return View();
    }
}