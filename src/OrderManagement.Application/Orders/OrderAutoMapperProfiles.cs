using AutoMapper;
using AutoMapper.Configuration.Annotations;
using OrderManagement.Orders.Dtos;
using OrderManagement.Orders.Entities;
using OrderManagement.Orders.ValueObjects;


namespace OrderManagement.Orders;

public class OrderAutoMapperProfiles : Profile
{
    public OrderAutoMapperProfiles()
    {
        CreateMap<Order, OrderDto>();
        CreateMap<Order, OrderListDto>();
        CreateMap<OrderItem, OrderItemDto>();
        CreateMap<OrderItemDto, OrderItem>()
            .ForMember(dest => dest.OrderId, opt => opt.Ignore()); 
        CreateMap<CreateAndUpdateOrderDto, Order>();
    }
}