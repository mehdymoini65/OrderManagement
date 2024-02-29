using System;
using OrderManagement.Orders.Entities;
using Volo.Abp.Domain.Repositories;

namespace OrderManagement.Orders.Repositories;

public interface IOrderRepository : IRepository<Order, Guid>
{

}
