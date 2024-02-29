using System.Threading.Tasks;

namespace OrderManagement.Data;

public interface IOrderManagementDbSchemaMigrator
{
    Task MigrateAsync();
}
