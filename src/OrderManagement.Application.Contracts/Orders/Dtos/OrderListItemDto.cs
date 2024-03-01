using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace OrderManagement.Orders.Dtos;

[Serializable]
public class OrderListDto : EntityDto<Guid>
{
    public int TotalPrice { get; set; }
}
