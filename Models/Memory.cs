using System.ComponentModel.DataAnnotations;
using GameHelperApp.Enums;

namespace GameHelperApp.Models;

public class Memory
{
    [Key]
    public int MemoryId { get; set; }
    
    public string MemoryName { get; set; }
    
    public Ram Ram { get; set; }
    
    public int Modules { get; set; }
    
    public string Timing { get; set; }
    
    public string Producer { get; set; }
    
    public bool Rgb { get; set; }
    
    public Delays Delays { get; set; }
    
    public decimal Price { get; set; }

}