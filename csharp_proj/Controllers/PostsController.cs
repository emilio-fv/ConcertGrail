using Microsoft.AspNetCore.Mvc;
using csharp_proj.Models;
using Microsoft.EntityFrameworkCore;
namespace csharp_proj.Controllers;

public class PostsController : Controller
{
    private MyContext Database; // Instantiate database

    public PostsController(MyContext database)
    {
        Database = database;
    }

    private int? userId // Checks if user logged in
    {
        get
        {
            return HttpContext.Session.GetInt32("UserId");
        }
    }

    private bool loggedIn
    {
        get
        {
            return userId != null;
        }
    }

    [HttpGet("/posts/new")] // Route: New Post Form
    public IActionResult NewPost()
    {
        if(!loggedIn) // Check if user logged in
        {
            return RedirectToAction("Index", "Users");
        }

        return View("NewPost");
    }


    [HttpPost("/posts/create")] // Route: Create Post
    public IActionResult Create(Post newPost)
    {
        if(!ModelState.IsValid) // Validate form data
        {
            return NewPost();
        }

        newPost.UserId = (int)userId; // Attach user ID to post
        Database.Add(newPost); // Add to db
        Database.SaveChanges(); // Save changes
        return RedirectToAction("Share", "Users"); // Redirect to Share page
    }
}