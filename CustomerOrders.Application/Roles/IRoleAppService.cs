using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CustomerOrders.Roles.Dto;

namespace CustomerOrders.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
