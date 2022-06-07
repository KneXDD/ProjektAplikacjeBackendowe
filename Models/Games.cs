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

    public Byte[] Cover { get; set; }
    
    //Foreign Key (MY)
    public Studios Studios { get; set; }

    public Engines Engines { get; set; }  
}