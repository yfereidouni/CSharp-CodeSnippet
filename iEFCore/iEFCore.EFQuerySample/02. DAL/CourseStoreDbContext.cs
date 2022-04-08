using iEFCore.EFQuerySample;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.EFQuerySample;

public class CourseStoreDbContext : DbContext
{
    #region DbSets
    public DbSet<Course> Courses { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<CourseTeachers> CourseTeachers { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Comment> Comments { get; set; } 
    #endregion

    #region Constructors
    public CourseStoreDbContext(DbContextOptions<CourseStoreDbContext> options) : base(options)
    {
    }
    #endregion

    #region Methods
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
    #endregion

}
