using System;
using System.Collections.Generic;

namespace OrderManagement.Orders.Dtos;
[Serializable]
public record CreateAndUpdateOrderDto 
{
    public List<OrderItemDto> OrderItems { get; set; }
}
