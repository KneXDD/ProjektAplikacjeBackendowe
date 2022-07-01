using GameHelperApp.ViewModel;
using Microsoft.AspNetCore.Identity;

namespace GameHelperApp.Services;

public interface IUserService
{
   string GetUserId();
    Task<IdentityResult> ChangePasswordAsync(ChangePasswordViewModel changePasswordViewModel);
}