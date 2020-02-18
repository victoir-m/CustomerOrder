using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using CustomerOrders.Authorization.Roles;
using CustomerOrders.Authorization.Users;
using CustomerOrders.MultiTenancy;

namespace CustomerOrders.EntityFramework
{
    public class CustomerOrdersDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public CustomerOrdersDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in CustomerOrdersDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of CustomerOrdersDbContext since ABP automatically handles it.
         */
        public CustomerOrdersDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public CustomerOrdersDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public CustomerOrdersDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
