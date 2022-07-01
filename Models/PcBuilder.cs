using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace GameHelperApp.Models;

public class PcBuilder
{
    [Key] 
    public int PcBuilderId { get; set; }

    public Cpu Cpu { get; set; }

    public Motherboard Motherboard { get; set; }

    public Memory Memory { get; set; }
    
    public Storge Storge { get; set; }

    public Gpu Gpu { get; set; }

    public Case Case { get; set; }

    public Psu Psu { get; set; }

    public String Description { get; set; }
}