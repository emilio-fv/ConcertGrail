using Microsoft.AspNetCore.Mvc;
namespace name_tbd.Controllers;     

public class ReviewsController : Controller
{
    // TODO Route: New Review Form
    [HttpGet("/reviews/new")]
    public IActionResult NewReview()
    {
        // TODO: Add name of new review form cshtml file
        return View("");
    }

    // TODO Route: Create Review 
    [HttpPost("/reviews/create")]
    public IActionResult Create()
    {
        return RedirectToAction("Share", "Users"); // Redirect to Share page
    }
}