using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoSalesUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Welcome to AutoTrader Website.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Address:23232 NE 10th PL,Sammamish-99797";
                              
            return View();
        }
    }
}