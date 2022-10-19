using Microsoft.AspNetCore.Mvc;
namespace name_tbd.Controllers;     

public class ListingsController : Controller
{
    // private MyContext _context;

    // public ListingsController(MyContext context)
    // {
    //     _context = context;
    // }

    // TODO Route: New Listing Form
    [HttpGet("/listings/new")]
    public IActionResult NewListing()
    {
        // TODO: Add name of new listing form cshtml file
        return View("");
    }

    // TODO Route: Create Listing 
    [HttpPost("/listings/create")]
    public IActionResult Create()
    {
        return RedirectToAction("Share", "Users"); // Redirect to Share page
    }
}