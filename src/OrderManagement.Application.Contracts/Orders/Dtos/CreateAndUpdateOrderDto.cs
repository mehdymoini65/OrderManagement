using System.Collections.Generic;

namespace OrderManagement.Orders.Dtos;

public record CreateAndUpdateOrderDto 
{
    public List<OrderItemDto> OrderItems { get; set; }
}
