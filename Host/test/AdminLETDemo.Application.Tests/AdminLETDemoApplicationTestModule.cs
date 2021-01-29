using Volo.Abp.Modularity;

namespace AdminLETDemo
{
    [DependsOn(
        typeof(AdminLETDemoApplicationModule),
        typeof(AdminLETDemoDomainTestModule)
        )]
    public class AdminLETDemoApplicationTestModule : AbpModule
    {

    }
}