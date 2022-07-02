using System.ComponentModel.DataAnnotations;

namespace GameHelperApp.ViewModel;

public class AddPcViewModel
{
    public int PcBuilderId { get; set; }
    
    [Display(Name = "CPU")]
    public int CpuId { get; set; }
    
    [Display(Name = "Motherboard")]
    public int MotherboardId { get; set; }
    
    [Display(Name = "Memory")]
    public int MemoryId { get; set; }
    
    [Display(Name = "Storge")]
    public int StorgeId { get; set; }
    
    [Display(Name = "GPU")]
    public int GpuId { get; set; }
    
    [Display(Name = "Case")]
    public int CaseId { get; set; }
    
    [Display(Name = "PSU")]
    public int PsuId { get; set; }
    
    public String Description { get; set; }
}