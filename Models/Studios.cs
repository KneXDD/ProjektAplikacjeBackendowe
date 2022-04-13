using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GameHelperApp.Enums;

namespace GameHelperApp.Models;

public class Studios
{
    [Key]
    public int StudioId { get; set; }

    public String Name { get; set; }

    public DateTime YearOfEstablishment { get; set; }

    public Countries Country { get; set; }

    [Column(TypeName = "nvarchar(MAX)")]
    public String CompanyDescriptiopn { get; set; }

    public Byte[] Logo { get; set; }

    public int NumberOfWorkers { get; set; }
}