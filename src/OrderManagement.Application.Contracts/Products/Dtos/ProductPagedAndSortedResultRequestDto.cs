using System;
using Volo.Abp.Application.Dtos;

namespace OrderManagement.Products.Dtos;

[Serializable]
public class ProductPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
{
    public string? Name { get; set; }
}
