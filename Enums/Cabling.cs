using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GameHelperApp.Enums;

public enum Cabling
{
    Modular,
    [Display(Name ="Semi-Modular")]
    Semimodular,
    [Display(Name ="Non-Modular")]
    Nonmodular
}