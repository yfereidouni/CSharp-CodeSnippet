using Microsoft.EntityFrameworkCore;


namespace iEFCore.HierarchicalData;

public class HierarchicalDbContext : DbContext
{
    #region DbSets
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Type01> Type01s { get; set; }
    public DbSet<Type02> Type02s { get; set; }
    public DbSet<Type03> Type03s { get; set; }
    public DbSet<Person> People { get; set; }
    public DbSet<Address> Addresses { get; set; }
    #endregion

    #region Constructors
    public HierarchicalDbContext(DbContextOptions<HierarchicalDbContext> options) : base(options)
    {
    }
    #endregion

    #region Methods
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=Hierarchical_DB;Integrated Security=true;Encrypt=false;");
        //optionsBuilder.UseSqlServer("Server=.;Initial Catalog=Hierarchical_DB;Integrated Security=true;Encrypt=false;" , options => options.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));
    }
    #endregion

}
