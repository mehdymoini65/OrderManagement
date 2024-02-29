using OrderManagement.Localization;
using Volo.Abp.AuditLogging;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.SettingManagement;
using Volo.Abp.Validation.Localization;

namespace OrderManagement;

[DependsOn(typeof(AbpAuditLoggingDomainSharedModule))]
public class OrderManagementDomainSharedModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<OrderManagementResource>("en")
                .AddBaseTypes(typeof(AbpValidationResource))
                .AddVirtualJson("/Localization/OrderManagement");

            options.DefaultResourceType = typeof(OrderManagementResource);
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace("OrderManagement", typeof(OrderManagementResource));
        });
    }
}
