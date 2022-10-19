using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ConcertGrail.Controllers;      

public class PostsController : Controller
{
    [HttpGet("/posts/new")] // Route: New Post Form
    public IActionResult NewPost()
    {
        // TODO: Add any necessary logic
        return View("NewPost");
    }

    
    [HttpPost("/posts/create")] // Route: Create Post
    public IActionResult Create()
    {
        // TODO: Any any necessary logic
        return RedirectToAction("Share", "Users"); // Redirect to Share page
    }
}