using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GameHelperApp.Enums;

namespace GameHelperApp.Models;

public class Case
{
    [Key]
    [DisplayName("Id")]
    public int CaseId { get; set; }
    
    [DisplayName("Case Model")]
    public string Name { get; set; }
    
    [DisplayName("Case Type")]
    public CaseType CaseType { get; set; }
    
    public string Producer { get; set; }
    
    [DisplayName("Number Of Fans")]
    public NumberOfFans NumberOfFans { get; set; }
    
    [DisplayName("Graphic Card Length")]
    public GraphicsCardLength GraphicsCardLength { get; set; }
    
    [DisplayName("RGB")]
    public bool Rgb { get; set; }
    
    public decimal Price { get; set; }
    
    public List<PcBuilder> PcBuilders { get; set; } = new List<PcBuilder>();
    
    
    
}