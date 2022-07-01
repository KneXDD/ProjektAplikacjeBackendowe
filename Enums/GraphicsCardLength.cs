using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GameHelperApp.Enums;

public enum GraphicsCardLength
{
    [Display(Name = "250mm")]
    First,
    [Display(Name = "300mm")]
    Second,
    [Display(Name = "350mm")]
    Third, 
    [Display(Name = "400mm")]
    Fourth
}