using GameHelperApp.Enums;

namespace GameHelperApp.ViewModel;

public class AddGameViewModel
{
    public int GameId { get; set; }
    
    public string Name { get; set; }
    
    public GameGenre Genre { get; set; }
    
    public DateTime ReleaseDate { get; set; }
    
    public string Cover { get; set; }
    
    public int StudioId { get; set; }
    
    public int EngineId { get; set; }
}