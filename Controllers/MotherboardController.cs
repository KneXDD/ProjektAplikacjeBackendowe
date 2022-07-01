using GameHelperApp.Models;
using GameHelperApp.Services;
using GameHelperApp.Static;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Controllers;
[Authorize(Roles = UserRoles.Admin)]
public class MotherboardController : Controller
{
    private readonly IServices<Motherboard> _service;

    public MotherboardController(IServices<Motherboard> service)
    {
        _service = service;
    }
    [AllowAnonymous]
    public async Task<IActionResult> Index()
    {
        var data = await _service.GetAllAsync();
        return View(data);
    }
    [AllowAnonymous]
    public async Task<IActionResult> Search(string search)
    {
        var data = await _service.GetAllAsync();
        if (!string.IsNullOrEmpty(search))
        {
            var filter = data.Where(n => string.Equals(n.MotherboardName, search, StringComparison.CurrentCultureIgnoreCase));
            return View("Index", filter);
        }
        return View("Index",data);
    }
    
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create([Bind("MotherboardName,SocketNumber,Producer,Rgb,CaseType,Price")] Motherboard motherboard)
    {
        if (!ModelState.IsValid)
        {
            return View(motherboard);
        }
        await _service.AddAsync(motherboard);
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
    public async Task<IActionResult> Edit(int id, Motherboard motherboard)
    {
        if (!ModelState.IsValid)
        {
            return View(motherboard);
        }
        await _service.UpdateAsync(id, motherboard);
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