using System;
using OrderManagement.Orders.Entities;
using Volo.Abp.Domain.Repositories;

namespace OrderManagement.Orders.Repository;

public interface IOrderRepository : IRepository<Order, Guid>
{

}
