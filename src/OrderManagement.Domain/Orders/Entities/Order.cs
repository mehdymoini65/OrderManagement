
using System;
using System.Collections.Generic;
using System.Linq;
using OrderManagement.Orders.ValueObjects;
using Volo.Abp.Domain.Entities.Auditing;

namespace OrderManagement.Orders.Entities;

public class Order : AuditedAggregateRoot<Guid>
{
    private List<OrderItem> _orderItems = new List<OrderItem>();

    public List<OrderItem> OrderItems
    {
        get => _orderItems;
        set
        {
            _orderItems = value;
            CalculateTotalPrice();
        }
    }

    public int TotalPrice {get; private set;}

    public void AddOrderItem(OrderItem orderItem)
    {
        _orderItems.Add(orderItem);
        CalculateTotalPrice();
    }

    public void RemoveOrderItem(OrderItem orderItem)
    {
        _orderItems.Remove(orderItem);
        CalculateTotalPrice();
    }

    private void CalculateTotalPrice()
    {
        TotalPrice = _orderItems.Sum(t => t.Quantity * t.Price);
    }
}
