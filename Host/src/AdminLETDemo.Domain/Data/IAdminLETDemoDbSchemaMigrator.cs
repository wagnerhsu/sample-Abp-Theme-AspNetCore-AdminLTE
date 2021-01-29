using System.Threading.Tasks;

namespace AdminLETDemo.Data
{
    public interface IAdminLETDemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
