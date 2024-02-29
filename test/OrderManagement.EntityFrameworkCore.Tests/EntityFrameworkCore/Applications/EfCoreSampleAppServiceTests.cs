using OrderManagement.Samples;
using Xunit;

namespace OrderManagement.EntityFrameworkCore.Applications;

[Collection(OrderManagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<OrderManagementEntityFrameworkCoreTestModule>
{

}
