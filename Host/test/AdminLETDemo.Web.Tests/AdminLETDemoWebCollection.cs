using AdminLETDemo.MongoDB;
using Xunit;

namespace AdminLETDemo
{
    [CollectionDefinition(AdminLETDemoTestConsts.CollectionDefinitionName)]
    public class AdminLETDemoWebCollection : AdminLETDemoMongoDbCollectionFixtureBase
    {

    }
}
