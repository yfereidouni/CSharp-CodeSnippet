using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.EFQuerySample;

public class CourseStoreContextFactory : IDesignTimeDbContextFactory<CourseStoreDbContext>
{
    public CourseStoreDbContext CreateDbContext(string[] args)
    {
        var optionBuilder = new DbContextOptionsBuilder<CourseStoreDbContext>();
        optionBuilder.UseSqlServer("Server=.;Initial Catalog=CourseStore_DB;Integrated Security=true;Encrypt=false;");
        CourseStoreDbContext ctx = new CourseStoreDbContext(optionBuilder.Options);
        return ctx;
    }
}
