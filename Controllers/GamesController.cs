using GameHelperApp.Models;
using GameHelperApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Controllers;

public class GamesController : Controller
{
    private readonly IGameService<Games> _service;

    public GamesController(IGameService<Games> service)
    {
        _service = service;
    }
    public async Task<IActionResult> Index()
    {
        var data = await _service.GetAllAsync();
        return View(data);
    }
    public async Task<IActionResult> Search(string search)
    {
        var data = await _service.GetAllAsync();
        if (!string.IsNullOrEmpty(search))
        {
            var filter = data.Where(n => n.Name.Contains(search));
            return View("Index", filter);
        }
        return View("Index",data);
    }
    
    public async Task<IActionResult> Create()
    {
        var dropdown = await _service.GetGameViewModel();
        ViewBag.Engines = new SelectList(dropdown.Engines, "EngineId", "Name");
        ViewBag.Studios = new SelectList(dropdown.Studios, "StudioId", "Name");
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create([Bind("Name,Genre,ReleaseDate,Cover,Studios,Engines")] Games games)
    {
        if (!ModelState.IsValid)
        {
            return View(games);
        }
        await _service.AddAsync(games);
        return RedirectToAction(nameof(Index));
    }
    public async Task<IActionResult> Edit(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null)
        {
            return View();
        }

        return View(result);
    }

    [HttpPost, ActionName("Edit")]
    public async Task<IActionResult> Edit(int id, Games games)
    {
        if (!ModelState.IsValid)
        {
            return View(games);
        }
        await _service.UpdateAsync(id, games);
        return RedirectToAction(nameof(Index));
    }
    
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null)
        {
            return View();
        }
        return View(result);
    }

    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result == null)
        {
            return View();
        }

        await _service.DeleteAsync(id);
        return RedirectToAction((nameof(Index)));
    }
}