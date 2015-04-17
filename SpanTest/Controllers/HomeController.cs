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
            SpanTest.Models.PutniNalog Nalog = new SpanTest.Models.PutniNalog();
            Nalog.Accommodation = true;
            return View(Nalog);
        }
    }
}
