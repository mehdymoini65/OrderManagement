using System.Collections.Generic;
using Volo.Abp.Domain.Values;

namespace OrderManagement.Orders.ValueObjects;

public class OrderItem : ValueObject
{
    public OrderItem(int productId, int orderId, int qantity, int price)
    {
        ProductId = productId;
        OrderId = orderId;
        Qantity = qantity;
        Price = price;
    }

    public int ProductId { get; private set; }
    public int OrderId { get; private set; }
    public int Qantity { get; private set; }
    public int Price { get; private set; }
    protected override IEnumerable<object> GetAtomicValues()
    {
        yield return ProductId;
        yield return OrderId;
        yield return Qantity;
        yield return Price;
    }
}
