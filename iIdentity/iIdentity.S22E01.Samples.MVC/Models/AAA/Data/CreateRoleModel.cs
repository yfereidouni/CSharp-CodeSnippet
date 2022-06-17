using System.ComponentModel.DataAnnotations;

namespace iIdentity.S22E01.Samples.MVC.Models.AAA.Data;

public class CreateRoleModel
{
    [Required]
    public string RoleName { get; set; }
}
