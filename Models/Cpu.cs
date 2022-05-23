using System.ComponentModel.DataAnnotations;
using GameHelperApp.Enums;

namespace GameHelperApp.Models;

public class Cpu
{
    [Key]
    public int CpuId { get; set; }
    
    public string CpuModel { get; set; }
    
    public string SocketNumber { get; set; }
    
    public string CoreClock { get; set; }
    
    public int PhysicalCores { get; set; }
    
    public SupportedMemories SupportedMemories { get; set; }
    
    public decimal Price { get; set; }
}