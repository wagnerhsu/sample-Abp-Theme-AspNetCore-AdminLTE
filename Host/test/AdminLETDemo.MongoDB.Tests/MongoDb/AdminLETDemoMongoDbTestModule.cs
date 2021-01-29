using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace AdminLETDemo.MongoDB
{
    [DependsOn(
        typeof(AdminLETDemoTestBaseModule),
        typeof(AdminLETDemoMongoDbModule)
        )]
    public class AdminLETDemoMongoDbTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var stringArray = AdminLETDemoMongoDbFixture.ConnectionString.Split('?');
                        var connectionString = stringArray[0].EnsureEndsWith('/')  +
                                                   "Db_" +
                                               Guid.NewGuid().ToString("N") + "/?" + stringArray[1];

            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = connectionString;
            });
        }
    }
}
