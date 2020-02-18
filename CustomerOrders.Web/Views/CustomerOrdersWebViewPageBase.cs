using Abp.Web.Mvc.Views;

namespace CustomerOrders.Web.Views
{
    public abstract class CustomerOrdersWebViewPageBase : CustomerOrdersWebViewPageBase<dynamic>
    {

    }

    public abstract class CustomerOrdersWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected CustomerOrdersWebViewPageBase()
        {
            LocalizationSourceName = CustomerOrdersConsts.LocalizationSourceName;
        }
    }
}