namespace iEFCore.HierarchicalData;

public class Type02
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Type01Id { get; set; }
    public Type01 Type01 { get; set; }
    public List<Type03> Type03s { get; set; }

}
