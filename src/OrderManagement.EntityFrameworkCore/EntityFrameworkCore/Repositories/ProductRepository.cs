using System;
using OrderManagement.EntityFrameworkCore;
using OrderManagement.Products.Entities;
using OrderManagement.Products.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace OrderManagement;

public class ProductRepository : EfCoreRepository<OrderManagementDbContext, Product, Guid>, IProductRepository
{
    public ProductRepository(IDbContextProvider<OrderManagementDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}