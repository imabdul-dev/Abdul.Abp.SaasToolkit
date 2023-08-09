using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Volo.Abp.TenantManagement.MongoDB;

public static class TenantManagementMongoDbContextExtensions
{
    public static void ConfigureTenantManagement(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
