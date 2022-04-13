using System.ComponentModel.DataAnnotations;
using GameHelperApp.Enums;

namespace GameHelperApp.Models;

public class Games
{
    [Key]
    public int GameId { get; set; }

    public String Name { get; set; }

    public GameGenre Genre { get; set; }
    
    public DateTime ReleaseDate { get; set; }

    public Byte[] Cover { get; set; }
    
    //Foreign Key (MY)
    public Studios Studios { get; set; }
}