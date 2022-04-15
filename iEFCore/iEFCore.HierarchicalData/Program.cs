using iEFCore.HierarchicalData;
using Microsoft.EntityFrameworkCore;

var optionBuilder = new DbContextOptionsBuilder<HierarchicalDbContext>();
optionBuilder.UseSqlServer("Server=.;Initial Catalog=Hierarchical_DB;Integrated Security=true;Encrypt=false;");
//optionBuilder.LogTo(Console.WriteLine);
HierarchicalDbContext ctx = new HierarchicalDbContext(optionBuilder.Options);


#region Reading Organizational Structures
// Reading Organizational Structures ----------------------------------------------
//HierarchicalData hierarchicalData = new HierarchicalData(ctx);
//var employee = hierarchicalData.GetEmployees();
//hierarchicalData.PrintHierarchicalEmployee(employee);
#endregion

#region Insert related data to DB
// Insert related data to DB --------------------------------------------------------
//SampleQueries sampleQueries = new SampleQueries(ctx);
//sampleQueries.AddTypes(0, 5);
//var typesWithNormalQuery = ctx.Type01s.Include(x => x.Type02s).ThenInclude(c=>c.Type03s).ToList();                 // Normal Query (meet database onec)
//var typesWithSplitQuery = ctx.Type01s.AsSplitQuery().Include(x => x.Type02s).ThenInclude(c => c.Type03s).ToList(); // Split Query (meet database multi-times)
#endregion

var person = ctx.People.Include(c=>c.Addresses).ToList();
ctx.ChangeTracker.Clear();
Console.ReadKey();
