using Volo.Abp.Modularity;

namespace OrderManagement;

public abstract class OrderManagementApplicationTestBase<TStartupModule> : OrderManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
