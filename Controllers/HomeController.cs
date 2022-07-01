using System.Diagnostics;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using GameHelperApp.Models;
using GameHelperApp.ViewModel;

namespace GameHelperApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }

    public IActionResult ContactUs()
    {
        return View();
    }

    [HttpPost]
    public IActionResult ContactUs(SendEmailViewModel sendEmailViewModel)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }

        try
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("gamehelperapp@nwhead.pl");
            mail.To.Add("gamehelperapp@nwhead.pl");
            mail.Subject = sendEmailViewModel.Subject;
            mail.IsBodyHtml = true;
            string con = "Name: " + sendEmailViewModel.Name;
            con += "<br/> Email: " + sendEmailViewModel.Email;
            con += "<br/> Message: " + sendEmailViewModel.Text;
            mail.Body = con;
            SmtpClient smtpClient = new SmtpClient("mail.nwhead.pl");
            NetworkCredential networkCredential = new NetworkCredential("gamehelperapp@nwhead.pl",""); //ADD Password
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = networkCredential;
            smtpClient.Port = 587;
            smtpClient.EnableSsl = false;
            smtpClient.Send(mail);
            TempData["Success"] = "Mail Send";
            ModelState.Clear();
        }
        catch (Exception )
        {
            
            TempData["Error"] = "Mail Wrong";
        }
        return View();
    }
}