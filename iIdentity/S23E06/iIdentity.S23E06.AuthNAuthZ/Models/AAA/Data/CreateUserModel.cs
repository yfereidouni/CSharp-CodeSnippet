using System.ComponentModel.DataAnnotations;

namespace iIdentity.S23E06.AuthNAuthZ.Models.AAA.Data;

public class CreateUserModel
{
    [Required]
    public string Username { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }

    [Required]
    public string SSN { get; set; }
}
