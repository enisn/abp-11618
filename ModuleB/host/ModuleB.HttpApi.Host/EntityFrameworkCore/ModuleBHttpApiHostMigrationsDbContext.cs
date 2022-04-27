using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace ModuleB.EntityFrameworkCore;

public class ModuleBHttpApiHostMigrationsDbContext : AbpDbContext<ModuleBHttpApiHostMigrationsDbContext>
{
    public ModuleBHttpApiHostMigrationsDbContext(DbContextOptions<ModuleBHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureModuleB();
    }
}
