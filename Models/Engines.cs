using System.ComponentModel.DataAnnotations;

namespace GameHelperApp.Models;

public class Engines
{
    [Key]
    public int EngineId { get; set; }

    public string Name { get; set; }
    
    public DateTime ReleaseDate { get; set; }

    public string Developer { get; set; }

    public string License { get; set; }

    public string EngineDescription { get; set; }

    public Byte[] EngineLogo { get; set; }
    
}