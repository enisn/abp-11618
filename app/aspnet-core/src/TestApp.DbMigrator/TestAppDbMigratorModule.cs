using TestApp.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace TestApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TestAppMongoDbModule),
    typeof(TestAppApplicationContractsModule)
    )]
public class TestAppDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
