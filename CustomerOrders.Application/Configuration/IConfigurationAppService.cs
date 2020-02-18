using System.Threading.Tasks;
using Abp.Application.Services;
using CustomerOrders.Configuration.Dto;

namespace CustomerOrders.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}