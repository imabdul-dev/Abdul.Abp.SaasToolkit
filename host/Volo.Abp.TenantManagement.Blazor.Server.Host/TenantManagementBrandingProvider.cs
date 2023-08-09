using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Volo.Abp.TenantManagement.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class TenantManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TenantManagement";
}
