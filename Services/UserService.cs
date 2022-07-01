using System.Security.Claims;
using GameHelperApp.Models;
using GameHelperApp.ViewModel;
using Microsoft.AspNetCore.Identity;

namespace GameHelperApp.Services;
public class UserService : IUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly UserManager<AppUser> _userManager;
    public UserService(IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager)
    {
        _httpContextAccessor = httpContextAccessor;
        _userManager = userManager;
    }
    public string GetUserId()
    {
        return _httpContextAccessor.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);
    }

    public async Task<IdentityResult> ChangePasswordAsync(ChangePasswordViewModel changePasswordViewModel)
    {
        var userId = GetUserId();
        var user = await _userManager.FindByIdAsync(userId);
        return await _userManager.ChangePasswordAsync(user, changePasswordViewModel.CurrentPassword,
            changePasswordViewModel.NewPassword);

    }
}