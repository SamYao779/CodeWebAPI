using DemoWebAPI.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoWebAPI.Controllers
{
    public class HomeController : Controller
    {
        DemoWebAPIDbContext db = new DemoWebAPIDbContext();
        public ActionResult Index()
        {
            return View(db.Contacts.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}