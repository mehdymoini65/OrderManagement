using Microsoft.EntityFrameworkCore;
using OrderManagement.Orders.Entities;
using OrderManagement.Products.Entities;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;


namespace OrderManagement.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class OrderManagementDbContext :
    AbpDbContext<OrderManagementDbContext>
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity


    public OrderManagementDbContext(DbContextOptions<OrderManagementDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Order>(b =>
        {
            b.ToTable("Orders");
            b.HasMany(o => o.OrderItems)
             .WithOne()
             .HasForeignKey("OrderId");
        });
    }
}
