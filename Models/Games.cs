using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GameHelperApp.Enums;

namespace GameHelperApp.Models;

public class Games
{
    [Key]
    [DisplayName("Id")]
    public int GameId { get; set; }
    
    [DisplayName("Game Name")]
    public string Name { get; set; }

    [DisplayName("Game Type")]
    public GameGenre Genre { get; set; }
    
    [DisplayName("Release Date")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
    public DateTime ReleaseDate { get; set; }
    
    [DisplayName("Game Cover")]
    public string Cover { get; set; }
    
    //Foreign Key (MY)
    public Studios Studios { get; set; }
    [DisplayName("Studio")]
    public int StudioId { get; set; }

    public Engines Engines { get; set; }
    [DisplayName("Engine")]
    public int EngineId { get; set; }
    
    
}