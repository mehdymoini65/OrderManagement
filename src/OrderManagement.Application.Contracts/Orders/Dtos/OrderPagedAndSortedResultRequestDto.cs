using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace OrderManagement.Orders.Dtos;

public class OrderPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
{
    public int? TotalPrice { get; set; }
}
