using GameHelperApp.Models;
using GameHelperApp.Services;
using GameHelperApp.Static;
using GameHelperApp.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameHelperApp.Controllers;
[Authorize]
public class AccountController:Controller
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly AppDbContext _context;
    private readonly IUserService _userService;
    public AccountController(UserManager<AppUser> userManager,SignInManager<AppUser> signInManager, AppDbContext context,IUserService userService)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _context = context;
        _userService = userService;
    }

    public async Task<IActionResult> AllUsers()
    {
        var users = await _context.Users.ToListAsync();
        return View(users);
    }
    public async Task<IActionResult> Search(string search)
    {
        var users = await _context.Users.ToListAsync();
        if (!string.IsNullOrEmpty(search))
        {
            var filter = users.Where(n => n.UserName.Contains(search));
            return View("AllUsers", filter);
        }
        return View("AllUsers",users);
    }
    [AllowAnonymous]
    public IActionResult Login()
    {
        return View(new LoginViewModel());
    }
    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel loginViewModel)
    {
        if (!ModelState.IsValid)
        {
            return View(loginViewModel);
        }
        var user = await _userManager.FindByEmailAsync(loginViewModel.EmailAddress);
            if (user != null)
            {
                var checkPass = await _userManager.CheckPasswordAsync(user,loginViewModel.Password);
                if (checkPass)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password,false,false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Games");
                    }
                }
                TempData["Error"] = "Please try again!";
                return View(loginViewModel);
            }
            TempData["Error"] = "Please try again!";
            return View(loginViewModel);
    }
    [AllowAnonymous]
    public IActionResult Register()
    {
        return View(new RegisterViewModel());
    }
    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
    {
        if (!ModelState.IsValid)
        {
            return View(registerViewModel);
        }

        var user = await _userManager.FindByEmailAsync(registerViewModel.EmailAddress);
        if (user != null)
        {
            TempData["Error"] = "This email address is already in use";
            return View(registerViewModel);
        }

        var newUser = new AppUser()
        {
            FullName = registerViewModel.FullName,
            Email = registerViewModel.EmailAddress,
            UserName = registerViewModel.EmailAddress
        };
        var newUserResponse = await _userManager.CreateAsync(newUser, registerViewModel.Password);
        if (newUserResponse.Succeeded)
        {
            await _userManager.AddToRoleAsync(newUser, UserRoles.User);
        }

        return View("RegisterCompleted");
    }

    [HttpPost]
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }

    public IActionResult AccessDenied(string ReturnUrl)
    {
        return View();
    }
    
    public IActionResult ChangePassword()
    {
        return View(new ChangePasswordViewModel());
    }
    [HttpPost]
    public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
    {
        if (ModelState.IsValid)
        {
            var change = await _userService.ChangePasswordAsync(model);
            if (change.Succeeded)
            {
                ModelState.Clear();
                TempData["Success"] = "Password change";
                return View();
            }

            TempData["Error"] = "Wrong password";
        }
        return View(model);
    }
}