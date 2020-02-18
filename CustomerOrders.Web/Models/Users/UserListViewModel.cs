using System.Collections.Generic;
using CustomerOrders.Roles.Dto;
using CustomerOrders.Users.Dto;

namespace CustomerOrders.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}