namespace iEFCore.S24.E11.FromSQLInterpolated;

public class News
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string ShortDescription { get; set; }
    public string NewsBody { get; set; }
    public string ImageUrl { get; set; }
    public string RootTitr { get; set; }
}

public class NewsSummary
{
    public int Id { get; set; }
    public string Title { get; set; }
}