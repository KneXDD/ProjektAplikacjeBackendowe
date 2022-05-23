using System.ComponentModel.DataAnnotations;
using GameHelperApp.Enums;

namespace GameHelperApp.Models;

public class Gpu
{
    [Key]
    public int GpuId { get; set; }
    
    public SupportedMemoriesGPU SupportedMemoriesGPU { get; set; }
    
    public string GpuModel { get; set; }
    
    public string Company { get; set; }
    
    public bool Rgb { get; set; }
    
    public string Memory { get; set; }
    
    public decimal Price { get; set; }
}