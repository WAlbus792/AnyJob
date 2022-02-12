using AnyJob.Persistence.EntityConfigs;
using Microsoft.EntityFrameworkCore;

namespace AnyJob.Persistence;

/// <summary>
/// Db context connected with certain sql server
/// </summary>
public class AppDbContext : DbContext
{
    #region Constructor

    public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions) { }

    #endregion Constructor

    #region Methods

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        => modelBuilder.ApplyConfigurationsFromAssembly(typeof(EntityTypeConfigurationBase<>).Assembly);

    #endregion Methods
}