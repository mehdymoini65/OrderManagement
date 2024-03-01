using System;

namespace OrderManagement.Products.Dtos;

[Serializable]
public record OrderItemDto
{
public string Name { get; set; }
}
