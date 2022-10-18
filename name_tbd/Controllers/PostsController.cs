using Microsoft.AspNetCore.Mvc;
namespace name_tbd.Controllers;     

public class PostsController : Controller
{
    // TODO Route: New Post Form
    [HttpGet("/posts/new")]
    public IActionResult NewPost()
    {
        // TODO: Add name of new post form cshtml file
        return View("");
    }

    // TODO Route: Create Post 
    [HttpPost("/posts/create")]
    public IActionResult Create()
    {
        return RedirectToAction("Share", "Users"); // Redirect to Share page
    }
}