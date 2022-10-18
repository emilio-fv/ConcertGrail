using Microsoft.AspNetCore.Mvc;
namespace name_tbd.Controllers;     

public class CommentsController : Controller
{
    // TODO Route: Create Comment 
    [HttpPost("/comments/create")]
    public IActionResult Create()
    {
        return RedirectToAction("Share", "Users"); // Redirect to Share page
    }
}