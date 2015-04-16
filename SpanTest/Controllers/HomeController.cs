using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpanTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Header";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult PutniNalog()
        {
            return View();
        }
    }
}
