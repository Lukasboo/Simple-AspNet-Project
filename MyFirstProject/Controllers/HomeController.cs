using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstProject.Controllers
{
    public class HomeController : Controller
    {
        //Action Methods
        public ViewResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";
            //return "This is the Home Controller - About Method";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.ijk = "Hello this is the use of view bag";
            return View();
        }
    }
}