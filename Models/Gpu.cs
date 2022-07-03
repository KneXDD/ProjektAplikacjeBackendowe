using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GameHelperApp.Enums;

namespace GameHelperApp.Models;

public class Gpu
{
    [Key]
    [DisplayName("Id")]
    public int GpuId { get; set; }
    
    [DisplayName("Supported Memories")]
    public SupportedMemoriesGPU SupportedMemoriesGPU { get; set; }
    
    [DisplayName("Gpu Model")]
    public string GpuModel { get; set; }
    
    [DisplayName("Company Name")]
    public string Company { get; set; }
    
    [DisplayName("RGB")]
    public bool Rgb { get; set; }
    
    public string Memory { get; set; }
    
    public decimal Price { get; set; }
    
    public List<PcBuilder> PcBuilders { get; set; } = new List<PcBuilder>();
}