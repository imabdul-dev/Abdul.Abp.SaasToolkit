using Volo.Abp.Bundling;

namespace Volo.Abp.TenantManagement.Blazor.Host;

public class TenantManagementBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
