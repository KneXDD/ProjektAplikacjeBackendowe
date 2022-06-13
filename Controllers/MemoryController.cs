using GameHelperApp.Models;
using GameHelperApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Controllers;

public class MemoryController : Controller
{
    private readonly IServices<Memory> _service;

    public MemoryController(IServices<Memory> service)
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
    public async Task<IActionResult> Create([Bind("MemoryName,Ram,Modules,Timing,Producer,Rgb,Delays,Price")] Memory memory)
    {
        if (!ModelState.IsValid)
        {
            return View(memory);
        }
        await _service.AddAsync(memory);
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
    public async Task<IActionResult> Edit(int id, Memory memory)
    {
        if (!ModelState.IsValid)
        {
            return View(memory);
        }
        await _service.UpdateAsync(id, memory);
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