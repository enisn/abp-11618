using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ModuleB.EntityFrameworkCore;

public class ModuleBHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<ModuleBHttpApiHostMigrationsDbContext>
{
    public ModuleBHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ModuleBHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("ModuleB"));

        return new ModuleBHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
