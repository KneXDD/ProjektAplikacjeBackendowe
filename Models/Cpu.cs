using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GameHelperApp.Enums;

namespace GameHelperApp.Models;

public class Cpu
{
    [Key]
    [DisplayName("Id")]
    public int CpuId { get; set; }
    
    [DisplayName("Cpu Model")]
    public string CpuModel { get; set; }
    
    [DisplayName("Socket Number")]
    public string SocketNumber { get; set; }
    
    [DisplayName("Core Clock")]
    public string CoreClock { get; set; }
    
    [DisplayName("Physical Cores")]
    public int PhysicalCores { get; set; }
    
    [DisplayName("Supported Memories")]
    public SupportedMemories SupportedMemories { get; set; }
    
    public decimal Price { get; set; }

    public List<PcBuilder> PcBuilders { get; set; } = new List<PcBuilder>();
}