using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace myAbp.Controllers
{
    public abstract class myAbpControllerBase: AbpController
    {
        protected myAbpControllerBase()
        {
            LocalizationSourceName = myAbpConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
