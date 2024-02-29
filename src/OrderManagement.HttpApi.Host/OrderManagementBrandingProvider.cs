using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace OrderManagement;

[Dependency(ReplaceServices = true)]
public class OrderManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "OrderManagement";
}
