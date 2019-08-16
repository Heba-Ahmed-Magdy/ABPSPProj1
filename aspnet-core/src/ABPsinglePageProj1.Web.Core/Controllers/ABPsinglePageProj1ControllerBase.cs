using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ABPsinglePageProj1.Controllers
{
    public abstract class ABPsinglePageProj1ControllerBase: AbpController
    {
        protected ABPsinglePageProj1ControllerBase()
        {
            LocalizationSourceName = ABPsinglePageProj1Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
