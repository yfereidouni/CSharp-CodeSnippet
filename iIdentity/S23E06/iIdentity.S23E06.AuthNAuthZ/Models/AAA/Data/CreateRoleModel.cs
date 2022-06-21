using System.ComponentModel.DataAnnotations;

namespace iIdentity.S23E06.AuthNAuthZ.Models.AAA.Data;

public class CreateRoleModel
{
    [Required]
    public string RoleName { get; set; }
}
