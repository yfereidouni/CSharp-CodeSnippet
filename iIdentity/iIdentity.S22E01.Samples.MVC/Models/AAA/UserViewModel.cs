using System.ComponentModel.DataAnnotations;

namespace iIdentity.S22E01.Samples.MVC.Models.AAA;

public class UserViewModel
{
    [Required]
    public string Username { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
}
