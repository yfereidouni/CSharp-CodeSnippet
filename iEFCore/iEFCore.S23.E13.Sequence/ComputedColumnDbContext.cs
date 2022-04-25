using Microsoft.EntityFrameworkCore;

namespace iEFCore.S23.E13.Sequence;

public class SequenceDbContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=S23.E13.Sequence_DB;User Id=dbuser; Password=1qaz!QAZ;");

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasSequence("SampleSeq", "dbo", (c) =>
        {
            c.HasMin(100);
            c.HasMax(2000);
            c.IncrementsBy(20);
            c.StartsAt(101);
            c.IsCyclic();
        });
        //SQL Command: SELECT NEXT VALUE FOR [dbo].[SampleSeq]
    }
}
