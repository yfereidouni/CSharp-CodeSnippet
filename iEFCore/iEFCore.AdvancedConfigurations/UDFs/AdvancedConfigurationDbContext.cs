using iEFCore.AdvancedConfigurations.UDFs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.AdvancedConfigurations.UDFs;

public class AdvancedConfigurationDbContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=AdvancedConfiguration_DB;User Id=dbuser; Password=1qaz!QAZ;");

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Blog>()
            .HasMany(b => b.Posts)
            .WithOne(p => p.Blog);

        modelBuilder.Entity<Post>()
            .HasMany(p => p.Comments)
            .WithOne(c => c.Post);

        //Way-01
        modelBuilder.HasDbFunction(typeof(AdvancedConfigurationDbContext).GetMethod("BlogCommentCount", new[] { typeof(int) })).HasName("CommentedPostCountForBlog");

        //Way-02
        //modelBuilder.HasDbFunction(() => AdvancedConfigurationDbContext.BlogCommentCount(default)).HasName("CommentedPostCountForBlog");

        //Way-01
        modelBuilder.HasDbFunction(typeof(AdvancedConfigurationDbContext).GetMethod(nameof(PostsWithPopularComments), new[] { typeof(int) })).HasName("PostsWithPopularComments");
        //Way-02
        //modelBuilder.HasDbFunction(() => AdvancedConfigurationDbContext.BlogCommentCount(default)).HasName("PostsWithPopularComments");

    }

    //Scalar Function --------------
    //[DbFunction]
    public static int BlogCommentCount(int blogId)
    {
        throw new NotImplementedException();
    }

    //Table Value Function ---------
    public IQueryable<Post> PostsWithPopularComments(int likeThreshold)
            => FromExpression(() => PostsWithPopularComments(likeThreshold));
}


