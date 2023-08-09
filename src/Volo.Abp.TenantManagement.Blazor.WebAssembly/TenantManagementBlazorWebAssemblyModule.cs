using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Volo.Abp.TenantManagement.Blazor.WebAssembly;

[DependsOn(
    typeof(TenantManagementBlazorModule),
    typeof(AbpTenantManagementHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class TenantManagementBlazorWebAssemblyModule : AbpModule
{

}
