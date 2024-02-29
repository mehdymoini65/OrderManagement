using System;
using OrderManagement.EntityFrameworkCore;
using OrderManagement.Orders.Entities;
using OrderManagement.Orders.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace OrderManagement;

public class OrderRepository : EfCoreRepository<OrderManagementDbContext, Order, Guid>, IOrderRepository
{
    public OrderRepository(IDbContextProvider<OrderManagementDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}