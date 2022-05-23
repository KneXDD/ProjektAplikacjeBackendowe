using System.ComponentModel;

namespace GameHelperApp.Enums;

public enum Cabling
{
    Modular,
    [Description("Semi-Modular")]
    Semimodular,
    [Description("Non-Modular")]
    Nonmodular
}