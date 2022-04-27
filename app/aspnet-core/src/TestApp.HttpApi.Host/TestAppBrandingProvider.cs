using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TestApp;

[Dependency(ReplaceServices = true)]
public class TestAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TestApp";
}
