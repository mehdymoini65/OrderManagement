using System;
using Volo.Abp.Domain.Entities;

namespace OrderManagement.Products.Entities;

public class Product : AggregateRoot<Guid>
{
    public Product(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }

}
