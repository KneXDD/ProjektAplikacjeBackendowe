using System.ComponentModel.DataAnnotations;
using GameHelperApp.Enums;

namespace GameHelperApp.Models;

public class Motherboard
{
    [Key]
    public int MotherboardId { get; set; }
    
    public string MotherboardName { get; set; }
    
    public string SocketNumber { get; set; }
    
    public string Producer { get; set; }
    
    public bool Rgb { get; set; }
    
    public CaseType CaseType { get; set; }
    
    public decimal Price { get; set; }

}