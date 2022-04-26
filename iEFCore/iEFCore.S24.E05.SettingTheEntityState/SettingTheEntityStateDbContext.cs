using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.S24.E05.SettingTheEntityState;

public class SettingTheEntityStateDbContext: DbContext
{
    public DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=S24.E05.SettingTheEntityState_DB;User Id=dbuser; Password=1qaz!QAZ;");
    }
}
