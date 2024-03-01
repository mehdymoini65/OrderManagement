using System;
using OrderManagement.Orders.Entities;
using OrderManagement.Products.Entities;
using Volo.Abp.Domain.Entities;


namespace OrderManagement.Orders.ValueObjects;

public class OrderItem : Entity<Guid>
{

    public OrderItem() { }

    public OrderItem(Guid productId, Guid orderId, int quantity, int price)
    {
        ProductId = productId;
        OrderId = orderId;
        Quantity = quantity;
        Price = price;
    }

    public Guid ProductId { get; private set; }
    public Guid OrderId { get; private set; }
    public int Quantity { get; private set; }
    public int Price { get; private set; }

    public Product Product { get; set; }
}
