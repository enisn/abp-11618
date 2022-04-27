using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace ModuleB.MongoDB;

[ConnectionStringName(ModuleBDbProperties.ConnectionStringName)]
public class ModuleBMongoDbContext : AbpMongoDbContext, IModuleBMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureModuleB();
    }
}
