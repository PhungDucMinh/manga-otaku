using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using OtakuManga.Configuration.Dto;

namespace OtakuManga.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : OtakuMangaAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
