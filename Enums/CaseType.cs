using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GameHelperApp.Enums;

public enum CaseType
{
    [Display(Name ="Mini Tower")]
    MiniTower,
    [Display(Name ="Micro Tower")]
    MicroTower,
    [Display(Name ="Slim Tower")]
    SlimTower,
    [Display(Name ="Mini ITX")]
    MiniITX,
    [Display(Name ="Cube Case")]
    CubeCase,
    [Display(Name ="Midi Tower")]
    MidiTower,
    [Display(Name ="Big ower")]
    BigTower
}