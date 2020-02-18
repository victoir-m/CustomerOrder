using System.Web.Mvc;

namespace CustomerOrders.Web.Controllers
{
    public class AboutController : CustomerOrdersControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}