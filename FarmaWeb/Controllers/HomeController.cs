using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FarmaWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "FarmaWeb";

            return View();
        }

        public ActionResult Products()
        {
            ViewBag.Title = "Productos";

            return View();
        }
    }
}