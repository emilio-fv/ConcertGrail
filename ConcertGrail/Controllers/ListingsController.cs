using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ConcertGrail.Controllers;        

public class ListingsController : Controller
{
    // private MyContext _context;

    // public ListingsController(MyContext context)
    // {
    //     _context = context;
    // }

    [HttpGet("/listings/new")] // Route: New Listing Form
    public IActionResult New()
    {
        // TODO: Add any necessary logic
        return View("NewListing");
    }

    [HttpPost("/listings/create")] // Route: Create Listing 
    public IActionResult Create()
    {
        // TODO: Add any necessary logic
        return RedirectToAction("Share", "Users"); // Redirect to Share page
    }
}