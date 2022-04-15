namespace iEFCore.HierarchicalData;

public class Type03
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Type02Id { get; set; }
    public Type02 Type02 { get; set; }
}
