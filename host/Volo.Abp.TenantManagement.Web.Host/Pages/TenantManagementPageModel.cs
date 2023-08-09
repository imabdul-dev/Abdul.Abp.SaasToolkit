using Volo.Abp.TenantManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Volo.Abp.TenantManagement.Pages;

public abstract class TenantManagementPageModel : AbpPageModel
{
    protected TenantManagementPageModel()
    {
        LocalizationResourceType = typeof(AbpTenantManagementResource);
    }
}
