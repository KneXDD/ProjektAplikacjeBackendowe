using GameHelperApp.Models;

namespace GameHelperApp.ViewModel;

public class GamesViewModel
{
    public GamesViewModel()
    {
        Engines = new List<Engines>();
        Studios = new List<Studios>();
    }
    public List<Engines> Engines { get; set; }
    public List<Studios> Studios { get; set; }
}