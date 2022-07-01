using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GameHelperApp.Enums;

public enum NumberOfFans
{
    [Display(Name = "1")]
    One,
    [Display(Name = "2")]
    Two,
    [Display(Name = "3")]
    Three
}