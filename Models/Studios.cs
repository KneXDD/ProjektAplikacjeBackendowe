using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GameHelperApp.Enums;

namespace GameHelperApp.Models;

public class Studios
{
    [Key]
    public int StudioId { get; set; }

    public String Name { get; set; }

    [DisplayName("Year Of Establishment")]
    public DateTime YearOfEstablishment { get; set; }

    public Countries Country { get; set; }
    
    [DisplayName("Company Descriptiopn")]
    public String CompanyDescriptiopn { get; set; }

    public string Logo { get; set; }

    [DisplayName("Number Of Workers")]
    public int? NumberOfWorkers { get; set; }
    
    public List<Games> GamesList { get; set; } = new List<Games>();
}