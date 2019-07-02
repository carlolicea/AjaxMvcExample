using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class WordController : Controller
    {
        [HttpGet]
        public ActionResult Home()
        {
            return Redirect(Url.Content("~/Home.html"));
        }

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "IndexPage";
            return View();
        }
                
        [HttpPost]
        public ActionResult ChangeText()
        {
            string returnstring = "This has been changed";
            return Content(returnstring);
        }

        [HttpGet]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}