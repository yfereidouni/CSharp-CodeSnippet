using Microsoft.EntityFrameworkCore;

namespace iEFCore.Configurations.Entities;

[Keyless]
public class ReadOnlyAttribute
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

public class ReadOnlyFluent
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

