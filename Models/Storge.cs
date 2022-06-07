using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GameHelperApp.Enums;

namespace GameHelperApp.Models;

public class Storge
{
    [Key]
    public int StorgeId { get; set; }
    
    [DisplayName("Storge Name")]
    public string StorgeName { get; set; }
    
    public string Producer { get; set; }
    
    public bool SSD { get; set; }
    
    [DisplayName("Reade Speed")]
    public string ReadSpeed { get; set; }
    
    [DisplayName("Write Speed")]
    public string WriteSpeed { get; set; }
    
    public Interface Interface { get; set; }
    
    public Capacity Capacity { get; set; }
    
    public decimal Price { get; set; }
}