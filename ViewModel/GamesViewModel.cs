using GameHelperApp.Models;

namespace GameHelperApp.ViewModel;

public class GamesViewModel
{
    public GamesViewModel()
    {
        Engine = new List<Engines>();
        Studio = new List<Studios>();
    }
    public List<Engines> Engine { get; set; }
    public List<Studios> Studio { get; set; }
}