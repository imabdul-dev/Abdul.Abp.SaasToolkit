using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Volo.Abp.TenantManagement;

[Dependency(ReplaceServices = true)]
public class TenantManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TenantManagement";
}
