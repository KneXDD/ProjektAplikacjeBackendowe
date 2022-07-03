using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GameHelperApp.Enums;

namespace GameHelperApp.Models;

public class Storge
{
    [Key]
    [DisplayName("Id")]
    public int StorgeId { get; set; }
    
    [DisplayName("Storge Name")]
    public string StorgeName { get; set; }
    [DisplayName("Producer Name")]
    public string Producer { get; set; }
    
    public bool SSD { get; set; }
    
    [DisplayName("Read Speed")]
    public string ReadSpeed { get; set; }
    
    [DisplayName("Write Speed")]
    public string WriteSpeed { get; set; }
    [DisplayName("Interface Type")]
    public Interface Interface { get; set; }
    
    public Capacity Capacity { get; set; }
    
    public decimal Price { get; set; }
    
    public List<PcBuilder> PcBuilders { get; set; } = new List<PcBuilder>();
}