using OrderManagement.Samples;
using Xunit;

namespace OrderManagement.EntityFrameworkCore.Domains;

[Collection(OrderManagementTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<OrderManagementEntityFrameworkCoreTestModule>
{

}
