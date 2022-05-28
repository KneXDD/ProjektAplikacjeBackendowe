using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Controllers;

public class CaseController : Controller
{
    private readonly AppDbContext _context;

    public CaseController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var data = await _context.Case.ToListAsync();
        return View();
    }
}