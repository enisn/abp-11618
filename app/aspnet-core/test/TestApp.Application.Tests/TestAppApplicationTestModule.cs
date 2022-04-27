using Volo.Abp.Modularity;

namespace TestApp;

[DependsOn(
    typeof(TestAppApplicationModule),
    typeof(TestAppDomainTestModule)
    )]
public class TestAppApplicationTestModule : AbpModule
{

}
