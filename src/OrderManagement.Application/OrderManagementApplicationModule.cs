using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace OrderManagement;

[DependsOn(
    typeof(OrderManagementDomainModule),
    typeof(OrderManagementApplicationContractsModule)
    )]
public class OrderManagementApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<OrderManagementApplicationModule>();
        });
    }
}
