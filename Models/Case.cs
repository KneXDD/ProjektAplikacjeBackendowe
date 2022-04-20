using System.ComponentModel.DataAnnotations;
using GameHelperApp.Enums;

namespace GameHelperApp.Models;

public class Case
{
    [Key]
    public int CaseId { get; set; }

    public String Name { get; set; }

    public CaseType CaseType { get; set; }

    public String Company { get; set; }
    
    public NumberOfFans NumberOfFans { get; set; }

    public GraphicsCardLength GraphicsCardLength { get; set; }
    
    public decimal Price { get; set; }
    
    
    
}