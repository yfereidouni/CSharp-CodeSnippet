namespace iEFCore.EFQuerySample;

public class Tag
{
    public int TagId { get; set; }
    public string Name { get; set; }
    public ICollection<Course> Courses { get; set; }
    public bool IsDeleted { get; set; }
}
