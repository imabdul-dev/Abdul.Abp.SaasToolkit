﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Volo.TenantManagement.Module.Pages
{
    public class IndexModel : ModulePageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}