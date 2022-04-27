using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace ModuleA.MongoDB;

[ConnectionStringName(ModuleADbProperties.ConnectionStringName)]
public interface IModuleAMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
