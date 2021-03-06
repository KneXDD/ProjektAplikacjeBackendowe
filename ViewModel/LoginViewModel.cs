using System.ComponentModel.DataAnnotations;

namespace GameHelperApp.ViewModel;

public class LoginViewModel
{
    [Display(Name = "Email address")]
    [DataType(DataType.EmailAddress, ErrorMessage = "This is not an email address")]
    [Required(ErrorMessage = "Email address is required")]
    public string EmailAddress { get; set; }
    
    [Required(ErrorMessage = "Password is required")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}