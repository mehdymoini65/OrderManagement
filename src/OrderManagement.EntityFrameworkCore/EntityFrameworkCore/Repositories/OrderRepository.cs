using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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
    public override Task<Order> GetAsync(Guid id, bool includeDetails = true, CancellationToken cancellationToken = default)
    {
        IQueryable<Order> query = DbSet;

        if (includeDetails)
        {
            query = query.Include(o => o.OrderItems);
        }

        return query.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
    }
}