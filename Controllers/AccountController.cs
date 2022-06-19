using GameHelperApp.Models;
using GameHelperApp.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GameHelperApp.Controllers;

public class AccountController:Controller
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly AppDbContext _context;
    public AccountController(UserManager<AppUser> userManager,SignInManager<AppUser> signInManager, AppDbContext context)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _context = context;
    }
    public IActionResult Login()
    {
        return View(new LoginViewModel());
    }
    
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
}