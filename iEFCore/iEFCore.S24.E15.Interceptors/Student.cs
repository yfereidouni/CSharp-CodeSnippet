namespace iEFCore.S24.E15.Interceptors;


public interface IAuditable
{
    public DateTime InsertDate { get; set; }
    public DateTime UpdateDate { get; set; }
}

public class Student : IAuditable
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime InsertDate { get; set; }
    public DateTime UpdateDate { get; set; }
}

