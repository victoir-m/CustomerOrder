using System.Linq;
using CustomerOrders.EntityFramework;
using CustomerOrders.MultiTenancy;

namespace CustomerOrders.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly CustomerOrdersDbContext _context;

        public DefaultTenantCreator(CustomerOrdersDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
