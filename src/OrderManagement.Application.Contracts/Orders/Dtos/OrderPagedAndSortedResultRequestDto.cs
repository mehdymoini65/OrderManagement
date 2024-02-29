using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace OrderManagement.Orders.Dtos;

public class OrderPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
{
    public List<OrderItemDto> OrderItems { get; set; }
    public int TotalPrice { get; set; }
}
