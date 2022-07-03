using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GameHelperApp.Enums;

namespace GameHelperApp.Models;

public class Memory
{
    [Key]
    [DisplayName("Id")]
    public int MemoryId { get; set; }
    
    [DisplayName("Memory Model")]
    public string MemoryName { get; set; }
    
    [DisplayName("RAM Type")]
    public Ram Ram { get; set; }
    
    [DisplayName("Number Of Module")]
    public int Modules { get; set; }
    
    public string Timing { get; set; }
    
    [DisplayName("Producer Name")]
    public string Producer { get; set; }
    [DisplayName("RGB")]
    public bool Rgb { get; set; }
    
    public Delays Delays { get; set; }
    
    public decimal Price { get; set; }
    
    public List<PcBuilder> PcBuilders { get; set; } = new List<PcBuilder>();

}