using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using CustomerOrders.EntityFramework;

namespace CustomerOrders
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(CustomerOrdersCoreModule))]
    public class CustomerOrdersDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CustomerOrdersDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
