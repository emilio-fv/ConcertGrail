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
        // TODO: Add any necessary logic
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

    // TODO Route: Logout User

    [HttpGet("/dashboard")] // Route: Dashboard
    public IActionResult Dashboard()
    {
        // TODO Add any necessary logic
        return View("Dashboard");
    }

    [HttpGet("/events")] // Route: Events page
    public IActionResult Events()
    {
        // TODO Add any necessary logic
        return View("SearchEvents");
    }

    [HttpGet("/share")] // Route: Share page
    public IActionResult Share()
    {
        // TODO: Add any necessary logic
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