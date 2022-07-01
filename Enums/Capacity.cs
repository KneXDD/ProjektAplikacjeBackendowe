using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GameHelperApp.Enums;

public enum Capacity
{
    [Display(Name ="500GB")]
    a,
    [Display(Name ="1TB")]
    b,
    [Display(Name ="256GB")]
    c,
    [Display(Name ="3TB")]
    d,
    [Display(Name ="128GB")]
    e,
    [Display(Name ="480GB")]
    f
}