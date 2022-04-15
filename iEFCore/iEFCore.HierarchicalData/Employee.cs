namespace iEFCore.HierarchicalData;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int? ParentId { get; set; }
    public Employee Parent { get; set; }
    public List<Employee> Children { get; set; }
}
