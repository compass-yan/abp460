using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using myAbp.Configuration.Dto;

namespace myAbp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : myAbpAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
