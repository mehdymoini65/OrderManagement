namespace OrderManagement.Orders;

public class OrderTests
{
        [Fact]
    public void AddOrderItem_Should_Increase_OrderItems_Count()
    {
        // Arrange
        var order = new Order();
        var initialCount = order.OrderItems.Count;
        var orderItem = new OrderItem(Guid.NewGuid(), Guid.NewGuid(), 1, 100);

        // Act
        order.AddOrderItem(orderItem);

        // Assert
        order.OrderItems.Count.ShouldBe(initialCount + 1);
    }

    [Fact]
    public void RemoveOrderItem_Should_Decrease_OrderItems_Count()
    {
        // Arrange
        var order = new Order();
        var orderItem = new OrderItem(Guid.NewGuid(), Guid.NewGuid(), 1, 100);
        order.AddOrderItem(orderItem);
        var initialCount = order.OrderItems.Count;

        // Act
        order.RemoveOrderItem(orderItem);

        // Assert
        order.OrderItems.Count.ShouldBe(initialCount - 1);
    }
}