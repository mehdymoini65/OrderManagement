using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.SettingManagement.EntityFrameworkCore;


namespace OrderManagement.EntityFrameworkCore;

[DependsOn(
    typeof(OrderManagementDomainModule),
    typeof(AbpEntityFrameworkCoreSqlServerModule)
    )]
public class OrderManagementEntityFrameworkCoreModule : AbpModule
{

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<OrderManagementDbContext>(options =>
        {
                /* Remove "includeAllEntities: true" to create
                 * default repositories only for aggregate roots */
            options.AddDefaultRepositories(includeAllEntities: true);
        });

        Configure<AbpDbContextOptions>(options =>
        {
                /* The main point to change your DBMS.
                 * See also OrderManagementMigrationsDbContextFactory for EF Core tooling. */
            options.UseSqlServer();
        });

    }
}
