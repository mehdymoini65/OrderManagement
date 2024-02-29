using OrderManagement.Localization;
using Volo.Abp.Application.Services;

namespace OrderManagement;

/* Inherit your application services from this class.
 */
public abstract class OrderManagementAppService : ApplicationService
{
    protected OrderManagementAppService()
    {
        LocalizationResource = typeof(OrderManagementResource);
    }
}
