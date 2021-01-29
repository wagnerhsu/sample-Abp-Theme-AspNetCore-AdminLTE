using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AdminLETDemo.Data
{
    /* This is used if database provider does't define
     * IAdminLETDemoDbSchemaMigrator implementation.
     */
    public class NullAdminLETDemoDbSchemaMigrator : IAdminLETDemoDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}