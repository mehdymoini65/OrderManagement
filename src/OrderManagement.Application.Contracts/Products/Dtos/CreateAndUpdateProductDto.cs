using System;

namespace OrderManagement.Products.Dtos;
[Serializable]
public record CreateAndUpdateProductDto
{
    public string Name { get; set; }
}
