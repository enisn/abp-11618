using TestApp.MongoDB;
using Xunit;

namespace TestApp;

[CollectionDefinition(TestAppTestConsts.CollectionDefinitionName)]
public class TestAppApplicationCollection : TestAppMongoDbCollectionFixtureBase
{

}
