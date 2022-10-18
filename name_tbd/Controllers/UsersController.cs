using Microsoft.AspNetCore.Mvc;
namespace name_tbd.Controllers;     

public class UsersController : Controller
{
    // [HttpGet("/")] // Route: Landing Page
    // public IActionResult Index()
    // {
    //     // TODO: Add name of landing page cshtml file
    //     return View("");
    // }

    [HttpGet("/")] // Route: Login/Register 
    public IActionResult LoginRegister()
    {
        // TODO: Add name of login/register cshtml file
        return View("");
    }

    [HttpPost("/users/register")] // Route: Register User
    public IActionResult Register()
    {
        return RedirectToAction("Dashboard");
    }
    
    [HttpPost("/users/login")] // Route: Login User
    public IActionResult Login()
    {
        return RedirectToAction("Dashboard");
    }

    [HttpGet("/dashboard")] // Route: Dashboard
    public IActionResult Dashboard()
    {
        // TODO: add name of dashboard cshtml file
        return View("");
    }
}