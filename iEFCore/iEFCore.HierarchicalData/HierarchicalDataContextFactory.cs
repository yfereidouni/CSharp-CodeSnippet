using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.HierarchicalData;

public class HierarchicalDataContextFactory : IDesignTimeDbContextFactory<HierarchicalDbContext>
{
    public HierarchicalDbContext CreateDbContext(string[] args)
    {
        var optionBuilder = new DbContextOptionsBuilder<HierarchicalDbContext>();
        optionBuilder.UseSqlServer("Server=.;Initial Catalog=Hierarchical_DB;Integrated Security=true;Encrypt=false;");
        HierarchicalDbContext ctx = new HierarchicalDbContext(optionBuilder.Options);
        return ctx;
    }
}
