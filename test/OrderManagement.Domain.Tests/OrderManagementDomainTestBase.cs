using Volo.Abp.Modularity;

namespace OrderManagement;

/* Inherit from this class for your domain layer tests. */
public abstract class OrderManagementDomainTestBase<TStartupModule> : OrderManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
