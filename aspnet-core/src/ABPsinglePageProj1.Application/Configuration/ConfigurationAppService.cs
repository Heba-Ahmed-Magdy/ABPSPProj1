using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABPsinglePageProj1.Configuration.Dto;

namespace ABPsinglePageProj1.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPsinglePageProj1AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
