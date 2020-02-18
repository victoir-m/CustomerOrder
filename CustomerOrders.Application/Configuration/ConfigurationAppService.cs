using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CustomerOrders.Configuration.Dto;

namespace CustomerOrders.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CustomerOrdersAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
