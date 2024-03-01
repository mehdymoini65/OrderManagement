using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace OrderManagement.Orders.Dtos;

[Serializable]
public class OrderDto : EntityDto<Guid>
{
    public List<OrderItemDto> OrderItems { get; set; }
    public int TotalPrice { get; set; }

}