using System.ComponentModel.DataAnnotations;

namespace GameHelperApp.Models;

public class Gpu
{
    [Key]
    public int GpuId { get; set; }
}