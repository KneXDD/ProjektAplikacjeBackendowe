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
public class PcBuilderController : Controller
{
    private readonly IPcBuilderService _service;

    public PcBuilderController(IPcBuilderService service)
    {
        _service = service;
    }
    [AllowAnonymous]
    public async Task<IActionResult> Index()
    {
        var data = await _service.GetAllAsync();
        var dropdown = await _service.PcBuilderViewMode();
        ViewBag.CpuId = new SelectList(dropdown.Cpu, "CpuId", "CpuModel");
        ViewBag.MotherboardId = new SelectList(dropdown.Motherboard, "MotherboardId", "MotherboardName");
        ViewBag.MemoryId = new SelectList(dropdown.Memory, "MemoryId", "MemoryName");
        ViewBag.StorgeId = new SelectList(dropdown.Storge, "StorgeId", "StorgeName");
        ViewBag.GpuId = new SelectList(dropdown.Gpu, "GpuId", "GpuModel");
        ViewBag.CaseId = new SelectList(dropdown.Case, "CaseId", "Name");
        ViewBag.PsuId = new SelectList(dropdown.Psu, "PsuId", "PsuModel");
        return View(data);
    }
    
    [AllowAnonymous]
    public async Task<IActionResult> Details(int id)
    {
        var result = await _service.GetByIdAsync(id);
        return View(result);
    }
    
    public async Task<IActionResult> Create()
    {
        var dropdown = await _service.PcBuilderViewMode();
        ViewBag.CpuId = new SelectList(dropdown.Cpu, "CpuId", "CpuModel");
        ViewBag.MotherboardId = new SelectList(dropdown.Motherboard, "MotherboardId", "MotherboardName");
        ViewBag.MemoryId = new SelectList(dropdown.Memory, "MemoryId", "MemoryName");
        ViewBag.StorgeId = new SelectList(dropdown.Storge, "StorgeId", "StorgeName");
        ViewBag.GpuId = new SelectList(dropdown.Gpu, "GpuId", "GpuModel");
        ViewBag.CaseId = new SelectList(dropdown.Case, "CaseId", "Name");
        ViewBag.PsuId = new SelectList(dropdown.Psu, "PsuId", "PsuModel");
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(AddPcViewModel pcBuilder)
    {
        if (!ModelState.IsValid)
        {
            var dropdown = await _service.PcBuilderViewMode();
            ViewBag.CpuId = new SelectList(dropdown.Cpu, "CpuId", "CpuModel");
            ViewBag.MotherboardId = new SelectList(dropdown.Motherboard, "MotherboardId", "MotherboardName");
            ViewBag.MemoryId = new SelectList(dropdown.Memory, "MemoryId", "MemoryName");
            ViewBag.StorgeId = new SelectList(dropdown.Storge, "StorgeId", "StorgeName");
            ViewBag.GpuId = new SelectList(dropdown.Gpu, "GpuId", "GpuModel");
            ViewBag.CaseId = new SelectList(dropdown.Case, "CaseId", "Name");
            ViewBag.PsuId = new SelectList(dropdown.Psu, "PsuId", "PsuModel");
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

        var up = new AddPcViewModel()
        {
            PcBuilderId = result.PcBuilderId,
            CpuId = result.CpuId,
            MotherboardId = result.MotherboardId,
            MemoryId = result.MemoryId,
            StorgeId = result.StorgeId,
            GpuId = result.GpuId,
            CaseId = result.CaseId,
            PsuId = result.PsuId,
            Description = result.Description
        };
        
        var dropdown = await _service.PcBuilderViewMode();
        ViewBag.CpuId = new SelectList(dropdown.Cpu, "CpuId", "CpuModel");
        ViewBag.MotherboardId = new SelectList(dropdown.Motherboard, "MotherboardId", "MotherboardName");
        ViewBag.MemoryId = new SelectList(dropdown.Memory, "MemoryId", "MemoryName");
        ViewBag.StorgeId = new SelectList(dropdown.Storge, "StorgeId", "StorgeName");
        ViewBag.GpuId = new SelectList(dropdown.Gpu, "GpuId", "GpuModel");
        ViewBag.CaseId = new SelectList(dropdown.Case, "CaseId", "Name");
        ViewBag.PsuId = new SelectList(dropdown.Psu, "PsuId", "PsuModel");
        return View(up);
    }

    [HttpPost, ActionName("Edit")]
    public async Task<IActionResult> Edit(int id, AddPcViewModel pcBuilder)
    {
        if (id != pcBuilder.PcBuilderId)
            return View();
        if (!ModelState.IsValid)
        {
            var dropdown = await _service.PcBuilderViewMode();
            ViewBag.CpuId = new SelectList(dropdown.Cpu, "CpuId", "CpuModel");
            ViewBag.MotherboardId = new SelectList(dropdown.Motherboard, "MotherboardId", "MotherboardName");
            ViewBag.MemoryId = new SelectList(dropdown.Memory, "MemoryId", "MemoryName");
            ViewBag.StorgeId = new SelectList(dropdown.Storge, "StorgeId", "StorgeName");
            ViewBag.GpuId = new SelectList(dropdown.Gpu, "GpuId", "GpuModel");
            ViewBag.CaseId = new SelectList(dropdown.Case, "CaseId", "Name");
            ViewBag.PsuId = new SelectList(dropdown.Psu, "PsuId", "PsuModel");
            return View(pcBuilder);
        }
        await _service.UpdateAsync(pcBuilder);
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