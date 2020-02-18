using CustomerOrders.EntityFramework;
using EntityFramework.DynamicFilters;

namespace CustomerOrders.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly CustomerOrdersDbContext _context;

        public InitialHostDbBuilder(CustomerOrdersDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
