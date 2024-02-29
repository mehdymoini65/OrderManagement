using System;
using System.Threading.Tasks;
using OrderManagement.Orders.Dtos;
using Volo.Abp.Application.Services;

namespace OrderManagement.Orders;

public interface IOrderAppService : IApplicationService
{
    Task AddOrderItem(Guid orderId, OrderItemDto orderItemDto);
}
