using System.ComponentModel.DataAnnotations;
using GameHelperApp.Enums;

namespace GameHelperApp.Models;

public class Game
{
    [Key]
    public int GameId { get; set; }

    public String Name { get; set; }

    public GameGenre Genre { get; set; }
    
    public DateTime ReleaseDate { get; set; }

    public Byte[] Cover { get; set; }
}