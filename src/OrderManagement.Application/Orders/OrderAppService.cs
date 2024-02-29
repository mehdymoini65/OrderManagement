using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Orders.Dtos;
using OrderManagement.Orders.Entities;
using OrderManagement.Orders.Repositories;
using OrderManagement.Orders.ValueObjects;
using Volo.Abp.Application.Services;


namespace OrderManagement.Orders;

public class OrderAppService : CrudAppService<Order, OrderDto, OrderListItemDto, Guid, OrderPagedAndSortedResultRequestDto, CreateAndUpdateOrderDto, CreateAndUpdateOrderDto>, IOrderAppService
{
    private readonly IOrderRepository _orderRepository;
    public OrderAppService(IOrderRepository orderRepository) : base(orderRepository)
    {
        _orderRepository = orderRepository;
    }


    [HttpPost]
    [Route("api/orders/{orderId}/items")]
    public async Task AddOrderItem(Guid orderId, OrderItemDto orderItemDto)
    {
        var order = await _orderRepository.GetAsync(orderId);
        if (order == null)
        {
            throw new Exception($"Order with ID {orderId} not found.");
        }

        var orderItem = new OrderItem(
            Guid.NewGuid(),
            order.Id,
            orderItemDto.Quantity,
            orderItemDto.Price
        );

        order.AddOrderItem(orderItem);

        await _orderRepository.UpdateAsync(order);
    }
}
