using Volo.Abp;
using Volo.Abp.MongoDB;

namespace ModuleB.MongoDB;

public static class ModuleBMongoDbContextExtensions
{
    public static void ConfigureModuleB(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
