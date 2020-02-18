using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using CustomerOrders.Authorization.Users;
using CustomerOrders.MultiTenancy;
using CustomerOrders.Users;
using Microsoft.AspNet.Identity;

namespace CustomerOrders
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class CustomerOrdersAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected CustomerOrdersAppServiceBase()
        {
            LocalizationSourceName = CustomerOrdersConsts.LocalizationSourceName;
        }

        protected virtual async Task<User> GetCurrentUserAsync()
        {
            var user = await UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}