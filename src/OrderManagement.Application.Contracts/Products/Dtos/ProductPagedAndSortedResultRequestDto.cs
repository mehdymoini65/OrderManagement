using Volo.Abp.Application.Dtos;

namespace OrderManagement.Products.Dtos;

public class ProductPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
{
    public string? Name { get; set; }
}
