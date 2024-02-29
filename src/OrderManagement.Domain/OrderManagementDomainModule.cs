using Volo.Abp.Localization;
using Volo.Abp.Modularity;


namespace OrderManagement;

[DependsOn(typeof(OrderManagementDomainSharedModule))]
public class OrderManagementDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {

            options.Languages.Add(new LanguageInfo("en", "en", "English", "gb"));
        });
    }
}
