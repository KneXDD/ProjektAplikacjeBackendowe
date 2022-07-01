using System.ComponentModel.DataAnnotations;

namespace GameHelperApp.ViewModel;

public class SendEmailViewModel
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Subject { get; set; }
    [Required]
    public string Text { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}