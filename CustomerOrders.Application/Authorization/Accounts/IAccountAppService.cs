using System.Threading.Tasks;
using Abp.Application.Services;
using CustomerOrders.Authorization.Accounts.Dto;

namespace CustomerOrders.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
