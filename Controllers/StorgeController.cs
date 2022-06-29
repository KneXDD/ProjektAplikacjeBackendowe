using GameHelperApp.Models;
using GameHelperApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Controllers;

public class StorgeController : Controller
{
    private readonly IServices<Storge> _service;

    public StorgeController(IServices<Storge> service)
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
            var filter = data.Where(n => n.StorgeName.Contains(search));
            return View("Index", filter);
        }
        return View("Index",data);
    }
    
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create([Bind("StorgeName,Producer,SSD,ReadSpeed,WriteSpeed,Interface,Capacity,Price")] Storge storge)
    {
        if (!ModelState.IsValid)
        {
            return View(storge);
        }
        await _service.AddAsync(storge);
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
    public async Task<IActionResult> Edit(int id, Storge storge)
    {
        if (!ModelState.IsValid)
        {
            return View(storge);
        }
        await _service.UpdateAsync(id, storge);
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