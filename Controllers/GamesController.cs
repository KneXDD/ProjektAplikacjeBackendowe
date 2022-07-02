using GameHelperApp.Models;
using GameHelperApp.Services;
using GameHelperApp.Static;
using GameHelperApp.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Controllers;

[Authorize(Roles = UserRoles.Admin)]
public class GamesController : Controller
{
    private readonly IGameService _service;

    public GamesController(IGameService service)
    {
        _service = service;
    }
    [AllowAnonymous]
    public async Task<IActionResult> Index()
    {
        var data = await _service.GetAllAsync();
        var dropdown = await _service.GetGameViewModel();
        ViewBag.Engines = new SelectList(dropdown.Engine, "EngineId", "Name");
        ViewBag.Studios = new SelectList(dropdown.Studio, "StudioId", "Name");
        return View(data);
    }
    [AllowAnonymous]
    public async Task<IActionResult> Search(string search)
    {
        var data = await _service.GetAllAsync();
        if (!string.IsNullOrEmpty(search))
        {
            var filter = data.Where(n => string.Equals(n.Name, search, StringComparison.CurrentCultureIgnoreCase));
            return View("Index", filter);
        }
        return View("Index",data);
    }
    
    public async Task<IActionResult> Create()
    {
        var dropdown = await _service.GetGameViewModel();
        ViewBag.Engines = new SelectList(dropdown.Engine, "EngineId", "Name");
        ViewBag.Studios = new SelectList(dropdown.Studio, "StudioId", "Name");
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(AddGameViewModel games)
    {
        if (!ModelState.IsValid)
        {
            var dropdown = await _service.GetGameViewModel();
            ViewBag.Engines = new SelectList(dropdown.Engine, "EngineId", "Name");
            ViewBag.Studios = new SelectList(dropdown.Studio, "StudioId", "Name");
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

        var up = new AddGameViewModel()
        {
            GameId = result.GameId,
            Name = result.Name,
            Genre = result.Genre,
            ReleaseDate = result.ReleaseDate,
            Cover = result.Cover,
            StudioId = result.StudioId,
            EngineId = result.EngineId 
        };
        
        var dropdown = await _service.GetGameViewModel();
        ViewBag.Engines = new SelectList(dropdown.Engine, "EngineId", "Name");
        ViewBag.Studios = new SelectList(dropdown.Studio, "StudioId", "Name");
        return View(up);
    }

    [HttpPost, ActionName("Edit")]
    public async Task<IActionResult> Edit(int id, AddGameViewModel games)
    {
        if (id != games.GameId) 
            return View();
        if (!ModelState.IsValid)
        {
            var dropdown = await _service.GetGameViewModel();
            ViewBag.Engines = new SelectList(dropdown.Engine, "EngineId", "Name");
            ViewBag.Studios = new SelectList(dropdown.Studio, "StudioId", "Name");
            return View(games);
        }
        await _service.UpdateAsync(games);
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