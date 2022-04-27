using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace TestApp.MongoDB;

[DependsOn(
    typeof(TestAppTestBaseModule),
    typeof(TestAppMongoDbModule)
    )]
public class TestAppMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var stringArray = TestAppMongoDbFixture.ConnectionString.Split('?');
        var connectionString = stringArray[0].EnsureEndsWith('/') +
                                   "Db_" +
                               Guid.NewGuid().ToString("N") + "/?" + stringArray[1];

        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = connectionString;
        });
    }
}
