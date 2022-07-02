using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GameHelperApp.Enums;

namespace GameHelperApp.Models;

public class Games
{
    [Key]
    public int GameId { get; set; }

    public string Name { get; set; }

    public GameGenre Genre { get; set; }
    
    [DisplayName("Release Date")]
    public DateTime ReleaseDate { get; set; }

    public string Cover { get; set; }
    
    //Foreign Key (MY)
    public Studios Studios { get; set; }
    public int StudioId { get; set; }

    public Engines Engines { get; set; }
    public int EngineId { get; set; }
    
    
}