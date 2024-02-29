using Xunit;

namespace OrderManagement.EntityFrameworkCore;

[CollectionDefinition(OrderManagementTestConsts.CollectionDefinitionName)]
public class OrderManagementEntityFrameworkCoreCollection : ICollectionFixture<OrderManagementEntityFrameworkCoreFixture>
{

}
