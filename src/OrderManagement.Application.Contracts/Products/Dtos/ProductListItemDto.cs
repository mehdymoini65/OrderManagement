using System;
using Volo.Abp.Application.Dtos;

namespace OrderManagement.Products.Dtos;

public class ProductListItemDto : EntityDto<Guid>
{
    public string Name { get; set; }
}
