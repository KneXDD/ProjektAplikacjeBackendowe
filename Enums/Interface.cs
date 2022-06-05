using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GameHelperApp.Enums;

public enum Interface
{
    [Display(Name = "M.2")]
    M2,
    SATA,
    [Display(Name = "Sata III")]
    SATAIII
}