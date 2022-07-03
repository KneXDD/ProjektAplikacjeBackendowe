using System.ComponentModel;
using GameHelperApp.Enums;

namespace GameHelperApp.ViewModel;

public class AddGameViewModel
{
    [DisplayName("Id")]
    public int GameId { get; set; }
    [DisplayName("Game Name")]
    public string Name { get; set; }
    [DisplayName("Game Type")]
    public GameGenre Genre { get; set; }
    [DisplayName("Release Date")]
    public DateTime ReleaseDate { get; set; }
    [DisplayName("Game Cover")]
    public string Cover { get; set; }
    [DisplayName("Studio")]
    public int StudioId { get; set; }
    [DisplayName("Engine")]
    public int EngineId { get; set; }
}