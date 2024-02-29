using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace OrderManagement.Data;

/* This is used if database provider does't define
 * IOrderManagementDbSchemaMigrator implementation.
 */
public class NullOrderManagementDbSchemaMigrator : IOrderManagementDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
