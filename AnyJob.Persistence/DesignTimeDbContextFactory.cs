using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AnyJob.Persistence;

/// <summary>
/// Factory for db context to use in migrations
/// </summary>
internal class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<AppDbContext> builder = new();
        const string connectionString = "Server=(LocalDB)\\MSSQLLocalDB;Initial Catalog=AnyJob;Trusted_Connection=True;";
        builder.UseSqlServer(connectionString);
        builder.EnableSensitiveDataLogging();

        return new AppDbContext(builder.Options);
    }
}