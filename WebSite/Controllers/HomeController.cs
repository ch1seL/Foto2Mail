using System;
using System.Web.Mvc;

namespace eOrders.WebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}