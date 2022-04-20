using System.ComponentModel.DataAnnotations;

namespace GameHelperApp.Models;

public class Cpu
{
    [Key]
    public int CpuId { get; set; }
}