using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace ModuleA.EntityFrameworkCore;

public class ModuleAHttpApiHostMigrationsDbContext : AbpDbContext<ModuleAHttpApiHostMigrationsDbContext>
{
    public ModuleAHttpApiHostMigrationsDbContext(DbContextOptions<ModuleAHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureModuleA();
    }
}
