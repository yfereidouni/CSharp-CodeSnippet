namespace iEFCore.S23.E15.RowVersion;

public class Product 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public byte[] RowVersion { get; set; }
}



