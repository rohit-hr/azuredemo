using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleWebAppRHRAzureProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Rohit HR's page updated !!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Rohit";

            return View();
        }
    }
}