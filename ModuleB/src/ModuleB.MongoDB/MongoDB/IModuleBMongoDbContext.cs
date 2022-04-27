using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace ModuleB.MongoDB;

[ConnectionStringName(ModuleBDbProperties.ConnectionStringName)]
public interface IModuleBMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
