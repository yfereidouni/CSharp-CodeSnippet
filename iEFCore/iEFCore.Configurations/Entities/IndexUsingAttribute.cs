using Microsoft.EntityFrameworkCore;
using System;

namespace iEFCore.Configurations.Entities;

[Index(nameof(Name), IsUnique = true,Name ="IX_Name_USING_ATTRIBUTE")]
public class IndexUsingAttribute
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
