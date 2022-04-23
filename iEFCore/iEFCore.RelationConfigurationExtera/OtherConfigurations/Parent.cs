namespace iEFCore.RelationConfigurationExtera.OtherConfigurations;

public class Parent
{
    public int Id { get; set; }
    public string ParentName { get; set; }
    public string ParentCode { get; set; }
    public List<Child> Children { get; set; }
}
