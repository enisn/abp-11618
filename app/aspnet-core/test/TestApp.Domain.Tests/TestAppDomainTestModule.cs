using TestApp.MongoDB;
using Volo.Abp.Modularity;

namespace TestApp;

[DependsOn(
    typeof(TestAppMongoDbTestModule)
    )]
public class TestAppDomainTestModule : AbpModule
{

}
