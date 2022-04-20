using System.ComponentModel.DataAnnotations;

namespace GameHelperApp.Models;

public class Psu
{
    [Key]
    public int PsuId { get; set; }
}