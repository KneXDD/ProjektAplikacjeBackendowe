using System.ComponentModel;

namespace GameHelperApp.Enums;

public enum Interface
{
    [Description("M.2")]
    M2,
    SATA,
    [Description("Sata III")]
    SATAIII
}