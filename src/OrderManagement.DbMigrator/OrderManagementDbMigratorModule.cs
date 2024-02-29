using OrderManagement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace OrderManagement.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(OrderManagementEntityFrameworkCoreModule),
    typeof(OrderManagementApplicationContractsModule)
    )]
public class OrderManagementDbMigratorModule : AbpModule
{
}
