using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Volo.Abp.TenantManagement.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(TenantManagementBlazorModule)
    )]
public class TenantManagementBlazorServerModule : AbpModule
{

}
