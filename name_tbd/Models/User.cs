#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace name_tbd.Models;

public class User
{
    // === Fields ===
    [Key]
    public int UserId { get; set; }

    [Required(ErrorMessage = "is required.")]
    [Display(Name = "Username")]
    public string Username { get; set; }

    [Required(ErrorMessage = "is required.")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "is required.")]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "is required.")]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; }

    [Required(ErrorMessage = "is required.")]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }

    [NotMapped]
    [Compare("Password", ErrorMessage = "Passwords must match.")]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password")]
    public string ConfirmPassword { get; set; }

    // TODO: Add account type (general, artist)

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    // === Field Relationships ===
}