using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure.Persistence;

public class DatabaseContext:DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
    {
    }

    protected  override void OnModelCreating(ModelBuilder builder)
    {
        var assembly = Assembly.Load("Domain");
        builder.ApplyConfigurationsFromAssembly(assembly);
        SeedData(builder);

        base.OnModelCreating(builder);
    }

    #region dbsets
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    #endregion

    private void SeedData(ModelBuilder builder)
    {
    }
}

