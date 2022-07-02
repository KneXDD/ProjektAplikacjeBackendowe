using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GameHelperApp.Enums;

namespace GameHelperApp.Models;

public class Motherboard
{
    [Key]
    public int MotherboardId { get; set; }
    
    [DisplayName("Motherboard Name")]
    public string MotherboardName { get; set; }
    
    [DisplayName("Socket Number")]
    public string SocketNumber { get; set; }
    
    public string Producer { get; set; }
    
    public bool Rgb { get; set; }
    
    [DisplayName("Case Type")]
    public CaseType CaseType { get; set; }
    
    public decimal Price { get; set; }
    
    public List<PcBuilder> PcBuilders { get; set; } = new List<PcBuilder>();

}