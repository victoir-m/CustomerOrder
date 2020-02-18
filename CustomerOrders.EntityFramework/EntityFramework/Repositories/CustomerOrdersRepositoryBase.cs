using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace CustomerOrders.EntityFramework.Repositories
{
    public abstract class CustomerOrdersRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<CustomerOrdersDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected CustomerOrdersRepositoryBase(IDbContextProvider<CustomerOrdersDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class CustomerOrdersRepositoryBase<TEntity> : CustomerOrdersRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected CustomerOrdersRepositoryBase(IDbContextProvider<CustomerOrdersDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
