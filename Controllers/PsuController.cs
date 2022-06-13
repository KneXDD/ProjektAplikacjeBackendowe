using GameHelperApp.Models;
using GameHelperApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Controllers;

public class PsuController : Controller
{
    private readonly IServices<Psu> _service;

    public PsuController(IServices<Psu> service)
    {
        _service = service;
    }
    public async Task<IActionResult> Index()
    {
        var data = await _service.GetAllAsync();
        return View(data);
    }
    
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create([Bind("PsuModel,Power,Cabling,Rgb,Price")] Psu psu)
    {
        if (!ModelState.IsValid)
        {
            return View(psu);
        }
        await _service.AddAsync(psu);
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
    public async Task<IActionResult> Edit(int id, Psu psu)
    {
        if (!ModelState.IsValid)
        {
            return View(psu);
        }
        await _service.UpdateAsync(id, psu);
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