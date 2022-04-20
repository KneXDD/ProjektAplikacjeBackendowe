using System.ComponentModel.DataAnnotations;

namespace GameHelperApp.Models;

public class Memory
{
    [Key]
    public int MemoryId { get; set; }
}