using GameHelperApp.Models;
using GameHelperApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Controllers;

public class PcBuilderController : Controller
{
    private readonly IPcBuilderService<PcBuilder> _service;

    public PcBuilderController(IPcBuilderService<PcBuilder> service)
    {
        _service = service;
    }
    public async Task<IActionResult> Index()
    {
        var data = await _service.GetAllAsync();
        return View(data);
    }
    
    public async Task<IActionResult> Create()
    {
        var dropdown = await _service.PcBuilderViewMode();
        ViewBag.Cpu = new SelectList(dropdown.Cpu, "CpuId", "CpuModel");
        ViewBag.Motherboard = new SelectList(dropdown.Motherboard, "MotherboardId", "MotherboardName");
        ViewBag.Memory = new SelectList(dropdown.Memory, "MemoryId", "MemoryName");
        ViewBag.Storge = new SelectList(dropdown.Storge, "StorgeId", "StorgeName");
        ViewBag.Gpu = new SelectList(dropdown.Gpu, "GpuId", "GpuModel");
        ViewBag.Case = new SelectList(dropdown.Case, "CaseId", "Name");
        ViewBag.Psu = new SelectList(dropdown.Psu, "PsuId", "PsuModel");
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create([Bind("Cpu,Motherboard,Memory,Storge,Gpu,Case,Psu,Description")] PcBuilder pcBuilder)
    {
        if (!ModelState.IsValid)
        {
            return View(pcBuilder);
        }
        await _service.AddAsync(pcBuilder);
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
    public async Task<IActionResult> Edit(int id, PcBuilder pcBuilder)
    {
        if (!ModelState.IsValid)
        {
            return View(pcBuilder);
        }
        await _service.UpdateAsync(id, pcBuilder);
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