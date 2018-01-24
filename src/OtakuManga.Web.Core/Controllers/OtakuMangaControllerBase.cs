using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace OtakuManga.Controllers
{
    public abstract class OtakuMangaControllerBase: AbpController
    {
        protected OtakuMangaControllerBase()
        {
            LocalizationSourceName = OtakuMangaConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
