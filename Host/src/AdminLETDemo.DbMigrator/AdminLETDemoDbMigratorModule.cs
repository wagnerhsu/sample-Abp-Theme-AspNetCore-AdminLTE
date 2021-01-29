using AdminLETDemo.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AdminLETDemo.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AdminLETDemoMongoDbModule),
        typeof(AdminLETDemoApplicationContractsModule)
        )]
    public class AdminLETDemoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
