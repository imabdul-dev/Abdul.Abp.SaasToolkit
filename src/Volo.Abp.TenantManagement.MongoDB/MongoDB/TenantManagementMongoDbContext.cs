using System.Collections.Generic;
using MongoDB.Driver;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Volo.Abp.TenantManagement.MongoDB;

[ConnectionStringName(AbpTenantManagementDbProperties.ConnectionStringName)]
public class TenantManagementMongoDbContext : AbpMongoDbContext, ITenantManagementMongoDbContext
{
    public IMongoCollection<Tenant> Tenants => Collection<Tenant>();
    public IMongoCollection<Edition> Editions => Collection<Edition>();
    public IMongoCollection<TenantConnectionString> TenantConnectionStrings => Collection<TenantConnectionString>();

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureTenantManagement();
    }
}
