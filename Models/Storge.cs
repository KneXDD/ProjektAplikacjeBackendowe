using System.ComponentModel.DataAnnotations;
using GameHelperApp.Enums;

namespace GameHelperApp.Models;

public class Storge
{
    [Key]
    public int StorgeId { get; set; }
    
    public string StorgeName { get; set; }
    
    public string Producer { get; set; }
    
    public bool SSD { get; set; }
    
    public string ReadSpeed { get; set; }
    
    public string WriteSpeed { get; set; }
    
    public Interface Interface { get; set; }
    
    public Capacity Capacity { get; set; }
    
    public decimal Price { get; set; }
}