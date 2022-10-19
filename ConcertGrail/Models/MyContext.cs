#pragma warning disable CS8618 
using Microsoft.EntityFrameworkCore;
namespace ConcertGrail.Models;

public class MyContext : DbContext
{
    public MyContext(DbContextOptions options) : base(options) { }
    public DbSet<User> Users { get; set; } 
    // TODO: Add Posts
    // TODO: Add Comments
    // TODO: Add Reviews
    // TODO: Add Listings
}
