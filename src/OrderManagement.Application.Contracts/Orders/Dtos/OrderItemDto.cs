﻿using System;

namespace OrderManagement.Orders.Dtos;

[Serializable]
public record OrderItemDto
{
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
}
