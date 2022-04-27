using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace ModuleA.MongoDB;

[ConnectionStringName(ModuleADbProperties.ConnectionStringName)]
public class ModuleAMongoDbContext : AbpMongoDbContext, IModuleAMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureModuleA();
    }
}
