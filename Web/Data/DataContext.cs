using Microsoft.EntityFrameworkCore;
using Web.Data.Entities;

namespace Web.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PostCategory>().HasKey(pc => new { pc.PostId, pc.CategoryId });
        modelBuilder.Entity<PostTag>().HasKey(pt => new { pt.PostId, pt.TagId });
    }

    public DbSet<Category> Categories { get; set; }
}