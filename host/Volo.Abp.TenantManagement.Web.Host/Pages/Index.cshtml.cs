using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Volo.Abp.TenantManagement.Pages;

public class IndexModel : TenantManagementPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
