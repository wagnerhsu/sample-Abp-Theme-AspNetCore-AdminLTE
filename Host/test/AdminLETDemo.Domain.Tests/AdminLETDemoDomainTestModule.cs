using AdminLETDemo.MongoDB;
using Volo.Abp.Modularity;

namespace AdminLETDemo
{
    [DependsOn(
        typeof(AdminLETDemoMongoDbTestModule)
        )]
    public class AdminLETDemoDomainTestModule : AbpModule
    {

    }
}