using Microsoft.AspNetCore.Mvc;
namespace name_tbd.Controllers;     

public class UsersController : Controller
{
    // TODO Route: Landing Page
    
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

    // TODO Route: Dashboard
    [HttpGet("/dashboard")]
    public IActionResult Dashboard()
    {
        // TODO: add name of dashboard cshtml file
        return View("");
    }
}