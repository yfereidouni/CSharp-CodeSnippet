using System.ComponentModel.DataAnnotations;

namespace iIdentity.S23E06.AuthNAuthZ.Models.AAA.Data;

public class LoginModel
{
    //[Required]
    public string UserName { get; set; }
    //[Required]
    public string Password { get; set; }
    public bool RememberMe { get; set; }
    public string RedirectUrl { get; set; }
}
