using GameHelperApp.Models;
using GameHelperApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Controllers;

public class GpuController : Controller
{
    private readonly IServices<Gpu> _service;

    public GpuController(IServices<Gpu> service)
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
    public async Task<IActionResult> Create([Bind("SupportedMemoriesGPU,GpuModel,Company,Rgb,Memory,Price")] Gpu gpu)
    {
        if (!ModelState.IsValid)
        {
            return View(gpu);
        }
        await _service.AddAsync(gpu);
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
    public async Task<IActionResult> Edit(int id, Gpu gpu)
    {
        if (!ModelState.IsValid)
        {
            return View(gpu);
        }
        await _service.UpdateAsync(id, gpu);
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