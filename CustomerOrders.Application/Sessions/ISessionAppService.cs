using System.Threading.Tasks;
using Abp.Application.Services;
using CustomerOrders.Sessions.Dto;

namespace CustomerOrders.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
