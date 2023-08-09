using Volo.Abp.TenantManagement.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Volo.Abp.TenantManagement.Blazor.Server.Host;

public abstract class TenantManagementComponentBase : AbpComponentBase
{
    protected TenantManagementComponentBase()
    {
        LocalizationResource = typeof(TenantManagementResource);
    }
}
