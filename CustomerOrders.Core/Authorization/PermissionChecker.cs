using Abp.Authorization;
using CustomerOrders.Authorization.Roles;
using CustomerOrders.Authorization.Users;

namespace CustomerOrders.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
