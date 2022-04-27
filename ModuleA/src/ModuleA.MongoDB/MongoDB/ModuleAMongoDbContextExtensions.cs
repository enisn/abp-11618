using Volo.Abp;
using Volo.Abp.MongoDB;

namespace ModuleA.MongoDB;

public static class ModuleAMongoDbContextExtensions
{
    public static void ConfigureModuleA(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
