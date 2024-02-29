using System;
using OrderManagement.Products.Entities;
using Volo.Abp.Domain.Repositories;

namespace OrderManagement.Products.Repositories;

public interface IProductRepository : IRepository<Product, Guid>
{

}
