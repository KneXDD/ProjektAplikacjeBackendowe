using System.ComponentModel;

namespace GameHelperApp.Enums;

public enum CaseType
{
    [Description("Mini Tower")]
    MiniTower,
    [Description("Micro Tower")]
    MicroTower,
    [Description("Slim Tower")]
    SlimTower,
    [Description("Mini ITX")]
    MiniITX,
    [Description("Cube Case")]
    CubeCase,
    [Description("Midi Tower")]
    MidiTower,
    [Description("Big ower")]
    BigTower
}