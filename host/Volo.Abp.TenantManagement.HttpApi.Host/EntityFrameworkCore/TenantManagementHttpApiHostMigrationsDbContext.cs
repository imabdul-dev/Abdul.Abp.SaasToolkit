using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Volo.Abp.TenantManagement.EntityFrameworkCore;

public class TenantManagementHttpApiHostMigrationsDbContext : AbpDbContext<TenantManagementHttpApiHostMigrationsDbContext>
{
    public TenantManagementHttpApiHostMigrationsDbContext(DbContextOptions<TenantManagementHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureTenantManagement();
    }
}
