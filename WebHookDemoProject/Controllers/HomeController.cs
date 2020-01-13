using System.Web.Mvc;

namespace WebHookDemoProject.LogClasses
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
