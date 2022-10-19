using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ConcertGrail.Controllers;       

public class ReviewsController : Controller
{
    [HttpGet("/reviews/new")] // Route: New Review Form
    public IActionResult NewReview()
    {
        // TODO: Add any necessary logic
        return View("NewReview");
    }

    [HttpPost("/reviews/create")] // Route: Create Review 
    public IActionResult Create()
    {
        // TODO: Add any necessary logic
        return RedirectToAction("Share", "Users"); // Redirect to Share page
    }
}