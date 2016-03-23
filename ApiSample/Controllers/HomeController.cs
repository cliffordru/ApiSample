using ApiSample.Helpers;
using System.Web.Mvc;

namespace ApiSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToRoute(ConfigurationData.RouteHelp);
        }
    }
}
