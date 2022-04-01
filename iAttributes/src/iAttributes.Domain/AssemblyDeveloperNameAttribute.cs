
public class AssemblyDeveloperNameAttribute : Attribute
{
    private readonly string developerName;

    public AssemblyDeveloperNameAttribute(string DeveloperName)
    {
        developerName = DeveloperName;
    }
}