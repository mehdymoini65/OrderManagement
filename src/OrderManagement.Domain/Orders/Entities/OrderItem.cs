using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Values;

namespace OrderManagement.Orders.ValueObjects;

public class OrderItem : Entity<Guid>
{
    public OrderItem(Guid productId, Guid orderId, int qantity, int price)
    {
        ProductId = productId;
        OrderId = orderId;
        Qantity = qantity;
        Price = price;
    }

    public Guid ProductId { get; private set; }
    public Guid OrderId { get; private set; }
    public int Qantity { get; private set; }
    public int Price { get; private set; }
}
