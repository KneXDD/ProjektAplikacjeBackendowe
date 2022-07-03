using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GameHelperApp.Enums;

namespace GameHelperApp.Models;

public class Psu
{
    [Key]
    [DisplayName("Id")]
    public int PsuId { get; set; }
    
    [DisplayName("Psu Model")]
    public string PsuModel { get; set; }
    [DisplayName("Power (W)")]
    public string Power { get; set; }
    
    [DisplayName("Cabling Type")]
    public Cabling Cabling { get; set; }
    
    [DisplayName("RGB")]
    public bool Rgb { get; set; }
    
    public decimal Price { get; set; }
    
    public List<PcBuilder> PcBuilders { get; set; } = new List<PcBuilder>();

}