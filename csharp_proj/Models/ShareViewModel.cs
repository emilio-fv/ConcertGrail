#pragma warning disable CS8618
using csharp_proj.Models;
using System.ComponentModel.DataAnnotations;
namespace csharp_proj.Models;

public class ShareViewModel
{
    public IEnumerable<Post> Posts { get; set; }
    public IEnumerable<Review> Reviews { get; set; }
    public IEnumerable<Listing> Listings { get; set; }
}