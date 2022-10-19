using Microsoft.AspNetCore.Mvc;
namespace name_tbd.Controllers;     

public class UsersController : Controller
{
    // [HttpGet("/about")] // Route: Landing Page
    // public IActionResult Index()
    // {
    //     // TODO: Add name of landing page cshtml file
    //     return View("");
    // }

    [HttpGet("/")] // Route: Login/Register 
    public IActionResult LoginRegister()
    {
        // TODO: Add name of login/register cshtml file
        return View("Index");
    }

    [HttpPost("/register")] // Route: Register User
    public IActionResult Register()
    {
        return RedirectToAction("Dashboard");
    }
    
    [HttpPost("/login")] // Route: Login User
    public IActionResult Login()
    {
        return RedirectToAction("Dashboard");
    }

    [HttpGet("/dashboard")] // Route: Dashboard
    public IActionResult Dashboard()
    {
        // TODO: add name of dashboard cshtml file
        return View("Dashboard");
    }

    // TODO Route: Events page
    [HttpGet("/events")]
    public IActionResult Events()
    {
        // TODO: add name of events cshtml file
        return View("");
    }

    // TODO Route: Share page
    [HttpGet("/share")]
    public IActionResult Share()
    {
        // TODO: add name of share cshtml file
        return View("Share");
    }

    // TODO Route: Connect page
    [HttpGet("/connect")]
    public IActionResult Connect()
    {
        // TODO: add name of connect cshtml file
        return View("");
    }
    
    // TODO Route: User Profile page
    [HttpGet("/profile")]
    public IActionResult Profile()
    {
        // TODO: add name of profile cshtml file
        return View("");
    }
}