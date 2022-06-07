using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GameHelperApp.Enums;

namespace GameHelperApp.Models;

public class Psu
{
    [Key]
    public int PsuId { get; set; }
    
    [DisplayName("Psu Model")]
    public string PsuModel { get; set; }
    
    public string Power { get; set; }
    
    public Cabling Cabling { get; set; }
    
    public bool Rgb { get; set; }
    
    public decimal Price { get; set; }

}