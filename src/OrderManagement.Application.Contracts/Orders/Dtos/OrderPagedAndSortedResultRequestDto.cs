using System;
using Volo.Abp.Application.Dtos;

namespace OrderManagement.Orders.Dtos;

[Serializable]
public class OrderPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
{
    public int? TotalPrice { get; set; }
}
