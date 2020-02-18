using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace CustomerOrders.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : CustomerOrdersControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}