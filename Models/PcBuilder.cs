using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace GameHelperApp.Models;

public class PcBuilder
{
    [Key] 
    [Display(Name = "ID")]
    public int PcBuilderId { get; set; }
    [Display(Name = "CPU")]
    public int CpuId { get; set; }
    
    [ForeignKey("CpuId")]
    public Cpu Cpu { get; set; }
    [Display(Name = "Motherboard")]
    public int MotherboardId { get; set; }
    
    [ForeignKey("MotherboardId")]
    public Motherboard Motherboard { get; set; }
    [Display(Name = "Memory")]
    public int MemoryId { get; set; }
    
    [ForeignKey("MemoryId")]
    public Memory Memory { get; set; }
    [Display(Name = "Storge")]
    public int StorgeId { get; set; }
    
    [ForeignKey("StorgeId")]
    public Storge Storge { get; set; }
    [Display(Name = "GPU")]
    public int GpuId { get; set; }
    
    [ForeignKey("GpuId")]
    public Gpu Gpu { get; set; }
    [Display(Name = "Case")]
    public int CaseId { get; set; }
    
    [ForeignKey("CaseId")]
    public Case Case { get; set; }
    
    [Display(Name = "PSU")]
    public int PsuId { get; set; }
    
    [ForeignKey("PsuId")]
    public Psu Psu { get; set; }

    public String Description { get; set; }
}