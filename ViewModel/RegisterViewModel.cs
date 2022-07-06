using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GameHelperApp.ViewModel;

public class RegisterViewModel
{
    [Display(Name = "Full name")]
    [Required(ErrorMessage = "Full name is required")]
    public string FullName { get; set; }
    
    [Display(Name = "Email address")]
    [DataType(DataType.EmailAddress, ErrorMessage = "This is not an email address")]
    [Required(ErrorMessage = "Email address is required")]
    public string EmailAddress { get; set; }
    
    [Required(ErrorMessage = "Password is required")]
    [DataType(DataType.Password)]
    [RegularExpression(@"(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[!@#$&_/\*]).{6,18}", ErrorMessage = "Your password requires a minimum of 6 characters, 1 uppercase letter,1 lowercase letter, 1 number and a special character")]
    public string Password { get; set; }
    
    [Display(Name = "Confirm password")]
    [Required(ErrorMessage = "Confirm Password is required")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Passwords do not match")]
    public string ConfirmPassword { get; set; }
}