using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CustomerOrders.MultiTenancy.Dto;

namespace CustomerOrders.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
