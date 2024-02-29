using AutoMapper;
using OrderManagement.Orders.Dtos;
using OrderManagement.Orders.Entities;
using OrderManagement.Orders.ValueObjects;


namespace OrderManagement.Orders;

public class OrderAutoMapperProfiles : Profile
{
    public OrderAutoMapperProfiles()
    {
        CreateMap<Order, OrderDto>();
        CreateMap<Order, OrderListItemDto>();
        CreateMap<OrderItemDto, OrderItem>();
        CreateMap<OrderItem, OrderItemDto>();
        CreateMap<CreateAndUpdateOrderDto, Order>();
    }
}