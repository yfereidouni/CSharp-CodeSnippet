using iCourseStore.DAL.Courses;
using iCourseStore.Model.Courses.Entities;
using iCourseStore.Model.Orders.Entities;
using iCourseStore.Model.Tags.Entities;
using iCourseStore.Model.Teachers.Entities;
using Microsoft.EntityFrameworkCore;

namespace iCourseStore.DAL.CourseStoreDB;

public class CourseStoreDbContext : DbContext
{
    #region DbSets
    public DbSet<Course> Courses { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<CourseTeacher> CourseTeachers { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Order> Orders { get; set; }
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
        //modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        modelBuilder.ApplyConfiguration(new CourseConfiguration());
        //modelBuilder.ApplyConfiguration(new TeacherConfiguration());
        //modelBuilder.ApplyConfiguration(new CourseTeacherConfiguration());
        //modelBuilder.ApplyConfiguration(new TagConfiguration());
        //modelBuilder.ApplyConfiguration(new CommentConfiguration());
        //modelBuilder.ApplyConfiguration(new OrderConfiguration());
        //modelBuilder.ApplyConfiguration(new DiscountConfiguration());

        //For Shadow Properties:
        foreach (var item in modelBuilder.Model.GetEntityTypes())
        {
            modelBuilder.Entity(item.ClrType).Property<string>("CreateBy").HasMaxLength(50);
            modelBuilder.Entity(item.ClrType).Property<string>("UpdateBy").HasMaxLength(50);
            modelBuilder.Entity(item.ClrType).Property<DateTime>("CreateDate").HasMaxLength(50);
            modelBuilder.Entity(item.ClrType).Property<DateTime>("UpdateDate").HasMaxLength(50);
        }
    }


    //Global Gonfigurations
    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);
        //Config all string properties to nvarchar(100) instead of nvarchar(MAX)
        //configurationBuilder.Properties<string>().HaveMaxLength(100);
    }
    #endregion
}
