using GameHelperApp.Models;

namespace GameHelperApp.ViewModel;

public class PcBuilderViewMode
{
    public PcBuilderViewMode()
    {
        Cpu = new List<Cpu>();
        Motherboard = new List<Motherboard>();
        Memory = new List<Memory>();
        Storge = new List<Storge>();
        Gpu = new List<Gpu>();
        Case = new List<Case>();
        Psu = new List<Psu>();
    }
    public List<Cpu> Cpu { get; set; }
    public List<Motherboard> Motherboard { get; set; }
    public List<Memory> Memory { get; set; }
    public List<Storge> Storge { get; set; }
    public List<Gpu> Gpu { get; set; }
    public List<Case> Case { get; set; }
    public List<Psu> Psu { get; set; }
}